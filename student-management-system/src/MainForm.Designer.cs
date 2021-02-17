namespace student_management_system
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconBtnExit = new FontAwesome.Sharp.IconButton();
            this.iconBtnSettings = new FontAwesome.Sharp.IconButton();
            this.iconBtnSomething = new FontAwesome.Sharp.IconButton();
            this.iconBtnCourses = new FontAwesome.Sharp.IconButton();
            this.iconBtnStudents = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconBtnTitlebarExit = new FontAwesome.Sharp.IconButton();
            this.iconBtnTitleBarMinimize = new FontAwesome.Sharp.IconButton();
            this.iconBtnTitlebarMaximize = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.iconBtnExit);
            this.panelMenu.Controls.Add(this.iconBtnSettings);
            this.panelMenu.Controls.Add(this.iconBtnSomething);
            this.panelMenu.Controls.Add(this.iconBtnCourses);
            this.panelMenu.Controls.Add(this.iconBtnStudents);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(183, 552);
            this.panelMenu.TabIndex = 0;
            // 
            // iconBtnExit
            // 
            this.iconBtnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnExit.FlatAppearance.BorderSize = 0;
            this.iconBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconBtnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnExit.IconSize = 32;
            this.iconBtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExit.Location = new System.Drawing.Point(0, 313);
            this.iconBtnExit.Name = "iconBtnExit";
            this.iconBtnExit.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.iconBtnExit.Size = new System.Drawing.Size(183, 52);
            this.iconBtnExit.TabIndex = 5;
            this.iconBtnExit.Text = "Exit";
            this.iconBtnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnExit.UseVisualStyleBackColor = true;
            this.iconBtnExit.Click += new System.EventHandler(this.iconBtnExit_Click);
            // 
            // iconBtnSettings
            // 
            this.iconBtnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSettings.FlatAppearance.BorderSize = 0;
            this.iconBtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSettings.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iconBtnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSettings.IconSize = 32;
            this.iconBtnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSettings.Location = new System.Drawing.Point(0, 261);
            this.iconBtnSettings.Name = "iconBtnSettings";
            this.iconBtnSettings.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.iconBtnSettings.Size = new System.Drawing.Size(183, 52);
            this.iconBtnSettings.TabIndex = 4;
            this.iconBtnSettings.Text = "Settings";
            this.iconBtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSettings.UseVisualStyleBackColor = true;
            this.iconBtnSettings.Click += new System.EventHandler(this.iconBtnSettings_Click);
            // 
            // iconBtnSomething
            // 
            this.iconBtnSomething.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSomething.FlatAppearance.BorderSize = 0;
            this.iconBtnSomething.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSomething.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnSomething.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSomething.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.iconBtnSomething.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnSomething.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnSomething.IconSize = 32;
            this.iconBtnSomething.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSomething.Location = new System.Drawing.Point(0, 209);
            this.iconBtnSomething.Name = "iconBtnSomething";
            this.iconBtnSomething.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.iconBtnSomething.Size = new System.Drawing.Size(183, 52);
            this.iconBtnSomething.TabIndex = 3;
            this.iconBtnSomething.Text = "Something";
            this.iconBtnSomething.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSomething.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnSomething.UseVisualStyleBackColor = true;
            this.iconBtnSomething.Click += new System.EventHandler(this.iconBtnSomething_Click);
            // 
            // iconBtnCourses
            // 
            this.iconBtnCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnCourses.FlatAppearance.BorderSize = 0;
            this.iconBtnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnCourses.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnCourses.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCourses.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconBtnCourses.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnCourses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnCourses.IconSize = 32;
            this.iconBtnCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCourses.Location = new System.Drawing.Point(0, 157);
            this.iconBtnCourses.Name = "iconBtnCourses";
            this.iconBtnCourses.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.iconBtnCourses.Size = new System.Drawing.Size(183, 52);
            this.iconBtnCourses.TabIndex = 2;
            this.iconBtnCourses.Text = "Courses";
            this.iconBtnCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnCourses.UseVisualStyleBackColor = true;
            this.iconBtnCourses.Click += new System.EventHandler(this.iconBtnCourses_Click);
            // 
            // iconBtnStudents
            // 
            this.iconBtnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnStudents.FlatAppearance.BorderSize = 0;
            this.iconBtnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnStudents.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.iconBtnStudents.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnStudents.IconSize = 32;
            this.iconBtnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnStudents.Location = new System.Drawing.Point(0, 105);
            this.iconBtnStudents.Name = "iconBtnStudents";
            this.iconBtnStudents.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.iconBtnStudents.Size = new System.Drawing.Size(183, 52);
            this.iconBtnStudents.TabIndex = 1;
            this.iconBtnStudents.Text = "Students";
            this.iconBtnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnStudents.UseVisualStyleBackColor = true;
            this.iconBtnStudents.Click += new System.EventHandler(this.iconBtnStudents_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(183, 105);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitleBar.Controls.Add(this.iconBtnTitlebarMaximize);
            this.panelTitleBar.Controls.Add(this.iconBtnTitleBarMinimize);
            this.panelTitleBar.Controls.Add(this.iconBtnTitlebarExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.Black;
            this.panelTitleBar.Location = new System.Drawing.Point(183, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(794, 23);
            this.panelTitleBar.TabIndex = 1;
            // 
            // iconBtnTitlebarExit
            // 
            this.iconBtnTitlebarExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconBtnTitlebarExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.iconBtnTitlebarExit.FlatAppearance.BorderSize = 0;
            this.iconBtnTitlebarExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnTitlebarExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconBtnTitlebarExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnTitlebarExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnTitlebarExit.IconSize = 20;
            this.iconBtnTitlebarExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnTitlebarExit.Location = new System.Drawing.Point(764, 0);
            this.iconBtnTitlebarExit.Name = "iconBtnTitlebarExit";
            this.iconBtnTitlebarExit.Size = new System.Drawing.Size(30, 23);
            this.iconBtnTitlebarExit.TabIndex = 2;
            this.iconBtnTitlebarExit.UseVisualStyleBackColor = false;
            this.iconBtnTitlebarExit.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconBtnTitleBarMinimize
            // 
            this.iconBtnTitleBarMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconBtnTitleBarMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.iconBtnTitleBarMinimize.FlatAppearance.BorderSize = 0;
            this.iconBtnTitleBarMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnTitleBarMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconBtnTitleBarMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnTitleBarMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnTitleBarMinimize.IconSize = 20;
            this.iconBtnTitleBarMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconBtnTitleBarMinimize.Location = new System.Drawing.Point(709, 0);
            this.iconBtnTitleBarMinimize.Name = "iconBtnTitleBarMinimize";
            this.iconBtnTitleBarMinimize.Size = new System.Drawing.Size(30, 23);
            this.iconBtnTitleBarMinimize.TabIndex = 3;
            this.iconBtnTitleBarMinimize.UseVisualStyleBackColor = false;
            this.iconBtnTitleBarMinimize.Click += new System.EventHandler(this.iconBtnTitleBarMinimize_Click);
            // 
            // iconBtnTitlebarMaximize
            // 
            this.iconBtnTitlebarMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconBtnTitlebarMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(68)))));
            this.iconBtnTitlebarMaximize.FlatAppearance.BorderSize = 0;
            this.iconBtnTitlebarMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnTitlebarMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconBtnTitlebarMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnTitlebarMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnTitlebarMaximize.IconSize = 20;
            this.iconBtnTitlebarMaximize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBtnTitlebarMaximize.Location = new System.Drawing.Point(738, 0);
            this.iconBtnTitlebarMaximize.Name = "iconBtnTitlebarMaximize";
            this.iconBtnTitlebarMaximize.Size = new System.Drawing.Size(30, 23);
            this.iconBtnTitlebarMaximize.TabIndex = 4;
            this.iconBtnTitlebarMaximize.UseVisualStyleBackColor = false;
            this.iconBtnTitlebarMaximize.Click += new System.EventHandler(this.iconBtnTitlebarMaximize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 552);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Student Management System";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconBtnExit;
        private FontAwesome.Sharp.IconButton iconBtnSettings;
        private FontAwesome.Sharp.IconButton iconBtnSomething;
        private FontAwesome.Sharp.IconButton iconBtnCourses;
        private FontAwesome.Sharp.IconButton iconBtnStudents;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconBtnTitlebarExit;
        private FontAwesome.Sharp.IconButton iconBtnTitleBarMinimize;
        private FontAwesome.Sharp.IconButton iconBtnTitlebarMaximize;
    }
}

