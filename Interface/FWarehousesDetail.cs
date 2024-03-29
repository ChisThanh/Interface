﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataPlayer;
using OfficeOpenXml;

namespace Interface
{
    public partial class FWarehousesDetail : Form
    {
        string id;
        List<Tuple<string, int>> _l = new List<Tuple<string, int>>();

        public FWarehousesDetail()
        {
            InitializeComponent();
        }

        public FWarehousesDetail(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        private async void FPurchaseOrderDetail_Load(object sender, EventArgs e)
        {
            Warehouse w = new Warehouse();

            var list = await w.GetProductInWarehouse(id);
            _l = list;
            if (list == null || list.Count <= 0)
            {
                this.Visible = true;
                MessageBox.Show("Không có sản phẩm nào!");
                this.Close();
            }

            foreach ( var item in list )
            {
                int rowIndex = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[rowIndex].Cells["Column1"].Value = item.Item1;
                guna2DataGridView1.Rows[rowIndex].Cells["Column2"].Value = item.Item2;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                var folderPath = folderDialog.SelectedPath;


                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                string fileName = "WarehouseDetail.xlsx";
                string filePath = Path.Combine(folderPath, fileName);

                // Tạo một tệp Excel mới
                bool fileExists = File.Exists(filePath);
                FileInfo newFile = new FileInfo(filePath);

                using (ExcelPackage package = new ExcelPackage(newFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

                    int rowStart = 2;
                    int colStart = 1;
                    worksheet.Cells[1, 1].Value = "Trên sản phẩm";
                    worksheet.Cells[1, 2].Value = "Số lượng";



                    foreach (var item in _l)
                    {
                        worksheet.Cells[rowStart, colStart].Value = item.Item1;
                        worksheet.Cells[rowStart, colStart + 1].Value = item.Item2;
                        rowStart++;
                    }

                    worksheet.Cells.AutoFitColumns();
                    package.Save();
                }

                MessageBox.Show("Tạo tệp Excel thành công.");

            }
        }
    }
}
