
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Priority = new System.Windows.Forms.TextBox();
            this.Requirement = new System.Windows.Forms.TextBox();
            this.Module = new System.Windows.Forms.TextBox();
            this.Submodule = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.ExportExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Requirement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Submodule";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Result";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(12, 36);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(138, 40);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // Priority
            // 
            this.Priority.Location = new System.Drawing.Point(12, 125);
            this.Priority.Multiline = true;
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(138, 41);
            this.Priority.TabIndex = 8;
            this.Priority.TextChanged += new System.EventHandler(this.Priority_TextChanged);
            // 
            // Requirement
            // 
            this.Requirement.Location = new System.Drawing.Point(12, 215);
            this.Requirement.Multiline = true;
            this.Requirement.Name = "Requirement";
            this.Requirement.Size = new System.Drawing.Size(138, 49);
            this.Requirement.TabIndex = 9;
            this.Requirement.TextChanged += new System.EventHandler(this.Requirement_TextChanged);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(12, 311);
            this.Module.Multiline = true;
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(138, 48);
            this.Module.TabIndex = 10;
            this.Module.TextChanged += new System.EventHandler(this.Module_TextChanged);
            // 
            // Submodule
            // 
            this.Submodule.Location = new System.Drawing.Point(199, 36);
            this.Submodule.Multiline = true;
            this.Submodule.Name = "Submodule";
            this.Submodule.Size = new System.Drawing.Size(105, 40);
            this.Submodule.TabIndex = 11;
            this.Submodule.TextChanged += new System.EventHandler(this.Submodule_TextChanged);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(199, 125);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(100, 234);
            this.Title.TabIndex = 12;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(369, 36);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(259, 261);
            this.Result.TabIndex = 13;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // ExportExcel
            // 
            this.ExportExcel.Location = new System.Drawing.Point(369, 311);
            this.ExportExcel.Name = "ExportExcel";
            this.ExportExcel.Size = new System.Drawing.Size(259, 47);
            this.ExportExcel.TabIndex = 14;
            this.ExportExcel.Text = "Export To Excel";
            this.ExportExcel.UseVisualStyleBackColor = true;
            this.ExportExcel.Click += new System.EventHandler(this.ExportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 388);
            this.Controls.Add(this.ExportExcel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Submodule);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Requirement);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox Priority;
        private System.Windows.Forms.TextBox Requirement;
        private System.Windows.Forms.TextBox Module;
        private System.Windows.Forms.TextBox Submodule;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button ExportExcel;
    }
}

