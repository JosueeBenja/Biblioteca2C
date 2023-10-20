namespace Biblioteca
{
    partial class LibEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibEliminar));
            pictureBox1 = new PictureBox();
            button7 = new Button();
            Volver = new Button();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(804, 452);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            button7.Location = new Point(701, 406);
            button7.Name = "button7";
            button7.Size = new Size(87, 32);
            button7.TabIndex = 15;
            button7.Text = "Salir";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Volver
            // 
            Volver.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            Volver.Location = new Point(12, 406);
            Volver.Name = "Volver";
            Volver.Size = new Size(85, 32);
            Volver.TabIndex = 17;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 46);
            label1.TabIndex = 19;
            label1.Text = "Eliminar Libros";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(552, 239);
            button1.Name = "button1";
            button1.Size = new Size(130, 68);
            button1.TabIndex = 33;
            button1.Text = "eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(115, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(400, 150);
            dataGridView1.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(115, 145);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 27;
            label3.Text = "Libro:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 152);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 30;
            // 
            // LibEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Volver);
            Controls.Add(button7);
            Controls.Add(pictureBox1);
            Name = "LibEliminar";
            Text = "LibEliminar";
            Load += LibEliminar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button7;
        private Button Volver;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox2;
    }
}