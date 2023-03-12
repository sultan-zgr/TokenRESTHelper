namespace TokenDeneme1
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
            this.bGetAll = new System.Windows.Forms.Button();
            this.txtResponce = new System.Windows.Forms.RichTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.bGet = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.bPost = new System.Windows.Forms.Button();
            this.bPut = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGetAll
            // 
            this.bGetAll.Location = new System.Drawing.Point(12, 26);
            this.bGetAll.Name = "bGetAll";
            this.bGetAll.Size = new System.Drawing.Size(91, 56);
            this.bGetAll.TabIndex = 0;
            this.bGetAll.Text = "GET ALL";
            this.bGetAll.UseVisualStyleBackColor = true;
            this.bGetAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResponce
            // 
            this.txtResponce.Location = new System.Drawing.Point(15, 109);
            this.txtResponce.Name = "txtResponce";
            this.txtResponce.Size = new System.Drawing.Size(653, 293);
            this.txtResponce.TabIndex = 1;
            this.txtResponce.Text = "";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(109, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 2;
            // 
            // bGet
            // 
            this.bGet.Location = new System.Drawing.Point(109, 59);
            this.bGet.Name = "bGet";
            this.bGet.Size = new System.Drawing.Size(100, 23);
            this.bGet.TabIndex = 3;
            this.bGet.Text = "GET";
            this.bGet.UseVisualStyleBackColor = true;
            this.bGet.Click += new System.EventHandler(this.bGet_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(247, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(247, 57);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(100, 23);
            this.txtJob.TabIndex = 5;
            // 
            // bPost
            // 
            this.bPost.Location = new System.Drawing.Point(365, 27);
            this.bPost.Name = "bPost";
            this.bPost.Size = new System.Drawing.Size(91, 56);
            this.bPost.TabIndex = 6;
            this.bPost.Text = "POST";
            this.bPost.UseVisualStyleBackColor = true;
            this.bPost.Click += new System.EventHandler(this.bPost_Click);
            // 
            // bPut
            // 
            this.bPut.Location = new System.Drawing.Point(462, 27);
            this.bPut.Name = "bPut";
            this.bPut.Size = new System.Drawing.Size(91, 56);
            this.bPut.TabIndex = 7;
            this.bPut.Text = "PUT";
            this.bPut.UseVisualStyleBackColor = true;
            this.bPut.Click += new System.EventHandler(this.bPut_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(559, 27);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(91, 56);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "DELETE";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 427);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bPut);
            this.Controls.Add(this.bPost);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bGet);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtResponce);
            this.Controls.Add(this.bGetAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGetAll;
        private System.Windows.Forms.RichTextBox txtResponce;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button bGet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button bPost;
        private System.Windows.Forms.Button bPut;
        private System.Windows.Forms.Button bDelete;
    }
}
