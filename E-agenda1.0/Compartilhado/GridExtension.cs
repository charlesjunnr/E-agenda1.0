

namespace E_agenda1._0.Compartilhado
{
    public static class GridExtension
    {
        public static void ConfigurarGridZebrado(this DataGridView grid)
        {
            Font font = new Font("Microsoft Reem Kufi", 9, FontStyle.Bold, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.Blue,
                SelectionForeColor = Color.White
                
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEscura;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.LightBlue,
                Font = font,
                SelectionBackColor = Color.Blue,
                SelectionForeColor = Color.White
            };
            grid.RowsDefaultCellStyle = linhaClara;
        }

        public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.Font = new Font("Microsoft Reem Kufi", 10, FontStyle.Italic, GraphicsUnit.Point, 0);

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;
        }
    }
}

