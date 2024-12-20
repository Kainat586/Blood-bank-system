namespace project
{
    partial class deletedonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletedonor));
            addeletedonorpanel = new Panel();
            deletedonortxtbtn = new Button();
            idfordeletedonorbtn = new Button();
            idtxtfordeletedonor = new TextBox();
            deletedonorpanel = new Panel();
            deletedonorbtn = new Button();
            addeletedonorpanel.SuspendLayout();
            SuspendLayout();
            // 
            // addeletedonorpanel
            // 
            addeletedonorpanel.BackColor = Color.Maroon;
            addeletedonorpanel.Controls.Add(deletedonortxtbtn);
            addeletedonorpanel.Dock = DockStyle.Top;
            addeletedonorpanel.Location = new Point(0, 0);
            addeletedonorpanel.Name = "addeletedonorpanel";
            addeletedonorpanel.Size = new Size(800, 112);
            addeletedonorpanel.TabIndex = 1;
            // 
            // deletedonortxtbtn
            // 
            deletedonortxtbtn.Anchor = AnchorStyles.None;
            deletedonortxtbtn.BackColor = Color.White;
            deletedonortxtbtn.FlatStyle = FlatStyle.Flat;
            deletedonortxtbtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonortxtbtn.ForeColor = Color.Maroon;
            deletedonortxtbtn.ImageAlign = ContentAlignment.MiddleRight;
            deletedonortxtbtn.Location = new Point(243, 31);
            deletedonortxtbtn.Name = "deletedonortxtbtn";
            deletedonortxtbtn.Size = new Size(310, 56);
            deletedonortxtbtn.TabIndex = 0;
            deletedonortxtbtn.Text = "DELETE DONOR";
            deletedonortxtbtn.UseVisualStyleBackColor = false;
            // 
            // idfordeletedonorbtn
            // 
            idfordeletedonorbtn.Anchor = AnchorStyles.None;
            idfordeletedonorbtn.BackColor = Color.Maroon;
            idfordeletedonorbtn.BackgroundImageLayout = ImageLayout.None;
            idfordeletedonorbtn.FlatStyle = FlatStyle.Flat;
            idfordeletedonorbtn.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold);
            idfordeletedonorbtn.ForeColor = Color.White;
            idfordeletedonorbtn.Location = new Point(284, 151);
            idfordeletedonorbtn.Name = "idfordeletedonorbtn";
            idfordeletedonorbtn.Size = new Size(88, 27);
            idfordeletedonorbtn.TabIndex = 2;
            idfordeletedonorbtn.Text = "Id:";
            idfordeletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // idtxtfordeletedonor
            // 
            idtxtfordeletedonor.Anchor = AnchorStyles.None;
            idtxtfordeletedonor.Location = new Point(405, 155);
            idtxtfordeletedonor.Name = "idtxtfordeletedonor";
            idtxtfordeletedonor.Size = new Size(122, 23);
            idtxtfordeletedonor.TabIndex = 3;
            // 
            // deletedonorpanel
            // 
            deletedonorpanel.Anchor = AnchorStyles.None;
            deletedonorpanel.Location = new Point(97, 199);
            deletedonorpanel.Name = "deletedonorpanel";
            deletedonorpanel.Size = new Size(590, 206);
            deletedonorpanel.TabIndex = 4;
            // 
            // deletedonorbtn
            // 
            deletedonorbtn.Anchor = AnchorStyles.None;
            deletedonorbtn.BackColor = Color.Maroon;
            deletedonorbtn.FlatStyle = FlatStyle.Flat;
            deletedonorbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletedonorbtn.ForeColor = Color.White;
            deletedonorbtn.Location = new Point(324, 424);
            deletedonorbtn.Name = "deletedonorbtn";
            deletedonorbtn.Size = new Size(124, 29);
            deletedonorbtn.TabIndex = 5;
            deletedonorbtn.Text = "Delete";
            deletedonorbtn.UseVisualStyleBackColor = false;
            // 
            // deletedonor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 465);
            Controls.Add(deletedonorbtn);
            Controls.Add(deletedonorpanel);
            Controls.Add(idtxtfordeletedonor);
            Controls.Add(idfordeletedonorbtn);
            Controls.Add(addeletedonorpanel);
            Name = "deletedonor";
            Text = "deletedonor";
            addeletedonorpanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel addeletedonorpanel;
        private Button deletedonortxtbtn;
        private Button idfordeletedonorbtn;
        private TextBox idtxtfordeletedonor;
        private Panel deletedonorpanel;
        private Button deletedonorbtn;
    }
}