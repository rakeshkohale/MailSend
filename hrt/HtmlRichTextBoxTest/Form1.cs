using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace HtmlRichTextBoxTest
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ToolBar tb1;
        private System.Windows.Forms.ToolBarButton tbbSeparator0;
        private System.Windows.Forms.ToolBarButton tbbLeft;
        private System.Windows.Forms.ToolBarButton tbbRight;
        private System.Windows.Forms.ToolBarButton tbbCenter;
        private System.Windows.Forms.ToolBarButton tbbSeparator5;
        private System.Windows.Forms.ToolBarButton tbbBold;
        private System.Windows.Forms.ToolBarButton tbbItalic;
        private System.Windows.Forms.ToolBarButton tbbUnderline;
        private System.Windows.Forms.ToolBarButton tbbSeparator1;
        private System.Windows.Forms.ToolBarButton tbbStrikeout;
        private System.Windows.Forms.ToolBarButton tbbFont;
        private System.Windows.Forms.ToolBarButton tbbSeparator4;
        private System.Windows.Forms.ToolBarButton tbbColor;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.Windows.Forms.ImageList imgList1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.ToolBarButton tbbOpen;
        private System.Windows.Forms.ToolBarButton tbbSave;
        private System.Windows.Forms.ToolBarButton tbbSeparator3;
        private HtmlRichText.HtmlRichTextBox richTextBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolBarButton tbbSeparator6;
        private System.Windows.Forms.ToolBarButton tbbSuperScript;
        private System.Windows.Forms.ToolBarButton tbbSubScript;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtBoxTo;
        private TextBox txtBoxSubject;
        private System.ComponentModel.IContainer components;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb1 = new System.Windows.Forms.ToolBar();
            this.tbbSeparator0 = new System.Windows.Forms.ToolBarButton();
            this.tbbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbbSave = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator1 = new System.Windows.Forms.ToolBarButton();
            this.tbbLeft = new System.Windows.Forms.ToolBarButton();
            this.tbbRight = new System.Windows.Forms.ToolBarButton();
            this.tbbCenter = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator3 = new System.Windows.Forms.ToolBarButton();
            this.tbbBold = new System.Windows.Forms.ToolBarButton();
            this.tbbItalic = new System.Windows.Forms.ToolBarButton();
            this.tbbUnderline = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator4 = new System.Windows.Forms.ToolBarButton();
            this.tbbStrikeout = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator5 = new System.Windows.Forms.ToolBarButton();
            this.tbbSuperScript = new System.Windows.Forms.ToolBarButton();
            this.tbbSubScript = new System.Windows.Forms.ToolBarButton();
            this.tbbSeparator6 = new System.Windows.Forms.ToolBarButton();
            this.tbbFont = new System.Windows.Forms.ToolBarButton();
            this.tbbColor = new System.Windows.Forms.ToolBarButton();
            this.imgList1 = new System.Windows.Forms.ImageList(this.components);
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTo = new System.Windows.Forms.TextBox();
            this.txtBoxSubject = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new HtmlRichText.HtmlRichTextBox();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbSeparator0,
            this.tbbOpen,
            this.tbbSave,
            this.tbbSeparator1,
            this.tbbLeft,
            this.tbbRight,
            this.tbbCenter,
            this.tbbSeparator3,
            this.tbbBold,
            this.tbbItalic,
            this.tbbUnderline,
            this.tbbSeparator4,
            this.tbbStrikeout,
            this.tbbSeparator5,
            this.tbbSuperScript,
            this.tbbSubScript,
            this.tbbSeparator6,
            this.tbbFont,
            this.tbbColor});
            this.tb1.ButtonSize = new System.Drawing.Size(16, 16);
            this.tb1.Divider = false;
            this.tb1.DropDownArrows = true;
            this.tb1.ImageList = this.imgList1;
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.ShowToolTips = true;
            this.tb1.Size = new System.Drawing.Size(675, 26);
            this.tb1.TabIndex = 2;
            this.tb1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tb1_ButtonClick);
            // 
            // tbbSeparator0
            // 
            this.tbbSeparator0.Name = "tbbSeparator0";
            this.tbbSeparator0.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbOpen
            // 
            this.tbbOpen.ImageIndex = 10;
            this.tbbOpen.Name = "tbbOpen";
            this.tbbOpen.ToolTipText = "Open";
            // 
            // tbbSave
            // 
            this.tbbSave.ImageIndex = 11;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.ToolTipText = "Save";
            // 
            // tbbSeparator1
            // 
            this.tbbSeparator1.Name = "tbbSeparator1";
            this.tbbSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbLeft
            // 
            this.tbbLeft.ImageIndex = 0;
            this.tbbLeft.Name = "tbbLeft";
            this.tbbLeft.ToolTipText = "Left";
            // 
            // tbbRight
            // 
            this.tbbRight.ImageIndex = 1;
            this.tbbRight.Name = "tbbRight";
            this.tbbRight.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbRight.ToolTipText = "Right";
            // 
            // tbbCenter
            // 
            this.tbbCenter.ImageIndex = 2;
            this.tbbCenter.Name = "tbbCenter";
            this.tbbCenter.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbCenter.ToolTipText = "Center";
            // 
            // tbbSeparator3
            // 
            this.tbbSeparator3.Name = "tbbSeparator3";
            this.tbbSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbBold
            // 
            this.tbbBold.ImageIndex = 3;
            this.tbbBold.Name = "tbbBold";
            this.tbbBold.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbBold.ToolTipText = "Bold";
            // 
            // tbbItalic
            // 
            this.tbbItalic.ImageIndex = 4;
            this.tbbItalic.Name = "tbbItalic";
            this.tbbItalic.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbItalic.ToolTipText = "Italic";
            // 
            // tbbUnderline
            // 
            this.tbbUnderline.ImageIndex = 5;
            this.tbbUnderline.Name = "tbbUnderline";
            this.tbbUnderline.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbUnderline.ToolTipText = "Underline";
            // 
            // tbbSeparator4
            // 
            this.tbbSeparator4.Name = "tbbSeparator4";
            this.tbbSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbStrikeout
            // 
            this.tbbStrikeout.ImageIndex = 6;
            this.tbbStrikeout.Name = "tbbStrikeout";
            this.tbbStrikeout.ToolTipText = "Strikeout";
            // 
            // tbbSeparator5
            // 
            this.tbbSeparator5.Name = "tbbSeparator5";
            this.tbbSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbSuperScript
            // 
            this.tbbSuperScript.ImageIndex = 12;
            this.tbbSuperScript.Name = "tbbSuperScript";
            this.tbbSuperScript.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbSuperScript.ToolTipText = "Super";
            // 
            // tbbSubScript
            // 
            this.tbbSubScript.ImageIndex = 13;
            this.tbbSubScript.Name = "tbbSubScript";
            this.tbbSubScript.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.tbbSubScript.ToolTipText = "Sub";
            // 
            // tbbSeparator6
            // 
            this.tbbSeparator6.Name = "tbbSeparator6";
            this.tbbSeparator6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbFont
            // 
            this.tbbFont.ImageIndex = 8;
            this.tbbFont.Name = "tbbFont";
            this.tbbFont.ToolTipText = "Font";
            // 
            // tbbColor
            // 
            this.tbbColor.ImageIndex = 9;
            this.tbbColor.Name = "tbbColor";
            this.tbbColor.ToolTipText = "Color";
            // 
            // imgList1
            // 
            this.imgList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList1.ImageStream")));
            this.imgList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList1.Images.SetKeyName(0, "");
            this.imgList1.Images.SetKeyName(1, "");
            this.imgList1.Images.SetKeyName(2, "");
            this.imgList1.Images.SetKeyName(3, "");
            this.imgList1.Images.SetKeyName(4, "");
            this.imgList1.Images.SetKeyName(5, "");
            this.imgList1.Images.SetKeyName(6, "");
            this.imgList1.Images.SetKeyName(7, "");
            this.imgList1.Images.SetKeyName(8, "");
            this.imgList1.Images.SetKeyName(9, "");
            this.imgList1.Images.SetKeyName(10, "");
            this.imgList1.Images.SetKeyName(11, "");
            this.imgList1.Images.SetKeyName(12, "");
            this.imgList1.Images.SetKeyName(13, "");
            // 
            // sfd1
            // 
            this.sfd1.DefaultExt = "htm";
            this.sfd1.Filter = "Html Files|*.htm;*.html|Rich Text Files|*.rtf|Plain Text File|*.txt|All Files|*.*" +
    "";
            this.sfd1.Title = "Save As";
            // 
            // ofd1
            // 
            this.ofd1.DefaultExt = "htm";
            this.ofd1.Filter = "Html Files|*.htm;*.html|Rich Text Files|*.rtf|Plain Text File|*.txt|All Files|*.*" +
    "";
            this.ofd1.Title = "Open File";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject";
            // 
            // txtBoxTo
            // 
            this.txtBoxTo.Location = new System.Drawing.Point(79, 40);
            this.txtBoxTo.Name = "txtBoxTo";
            this.txtBoxTo.Size = new System.Drawing.Size(168, 20);
            this.txtBoxTo.TabIndex = 7;
            // 
            // txtBoxSubject
            // 
            this.txtBoxSubject.Location = new System.Drawing.Point(79, 70);
            this.txtBoxSubject.Name = "txtBoxSubject";
            this.txtBoxSubject.Size = new System.Drawing.Size(168, 20);
            this.txtBoxSubject.TabIndex = 8;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 160);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(675, 388);
            this.Controls.Add(this.txtBoxSubject);
            this.Controls.Add(this.txtBoxTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void tb1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            //Switch based on the tooltip of the button pressed
            //OR: This could be changed to switch on the actual button pressed (e.g. e.Button and the case would be tbbBold)
            switch (e.Button.ToolTipText)
            {
                case "Bold":
                    {
                        if (richTextBox1.SelectionFont != null)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
                        }

                    }
                    break;

                case "Italic":
                    {
                        if (richTextBox1.SelectionFont != null)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
                        }
                    }
                    break;

                case "Underline":
                    {
                        if (richTextBox1.SelectionFont != null)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
                        }
                    }
                    break;

                case "Strikeout":
                    {
                        if (richTextBox1.SelectionFont != null)
                        {
                            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);
                        }
                    }
                    break;

                case "Super":
                    {
                        if (tbbSuperScript.Pushed)
                        {

                            richTextBox1.SetSuperScript(true);
                            richTextBox1.SetSubScript(false);

                        }
                        else
                        {

                            richTextBox1.SetSuperScript(false);
                        }
                    }
                    break;

                case "Sub":
                    {
                        if (tbbSubScript.Pushed)
                        {
                            richTextBox1.SetSubScript(true);
                            richTextBox1.SetSuperScript(false);
                        }
                        else
                        {
                            richTextBox1.SetSubScript(false);
                        }
                    }
                    break;
                case "Left":
                    {
                        //change horizontal alignment to left
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                    }
                    break;

                case "Right":
                    {
                        //change horizontal alignment to right
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                    }
                    break;

                case "Center":
                    {
                        //change horizontal alignment to center
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    }
                    break;

                case "Open":
                    {
                        try
                        {
                            if ((ofd1.ShowDialog() == DialogResult.OK) && (ofd1.FileName.Length > 0))
                            {
                                string strExt = System.IO.Path.GetExtension(ofd1.FileName).ToLower();

                                if (strExt == ".rtf")
                                {
                                    richTextBox1.LoadFile(ofd1.FileName, RichTextBoxStreamType.RichText);
                                }
                                else if (strExt == ".txt")
                                {
                                    richTextBox1.LoadFile(ofd1.FileName, RichTextBoxStreamType.PlainText);
                                }
                                else if ((strExt == ".htm") || (strExt == ".html"))
                                {
                                    // Read the HTML format
                                    StreamReader sr = File.OpenText(ofd1.FileName);
                                    string strHTML = sr.ReadToEnd();
                                    sr.Close();

                                    richTextBox1.AddHTML(strHTML);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("There was an error loading the file: " + ofd1.FileName);
                        }
                    }
                    break;

                case "Save":
                    {
                        if ((sfd1.ShowDialog() == DialogResult.OK) && (sfd1.FileName.Length > 0))
                        {
                            string strExt = System.IO.Path.GetExtension(sfd1.FileName).ToLower();

                            if (strExt == ".rtf")
                            {
                                richTextBox1.SaveFile(sfd1.FileName);
                            }
                            else if (strExt == ".txt")
                            {
                                richTextBox1.SaveFile(sfd1.FileName, RichTextBoxStreamType.PlainText);
                            }
                            else if ((strExt == ".htm") || (strExt == ".html"))
                            {
                                try
                                {
                                    // save as HTML format
                                    string strText = richTextBox1.GetHTML(true, true);

                                    if (File.Exists(sfd1.FileName))
                                        File.Delete(sfd1.FileName);

                                    StreamWriter sr = File.CreateText(sfd1.FileName);
                                    sr.Write(strText);
                                    sr.Close();
                                }
                                catch
                                {
                                    MessageBox.Show("There was an error saving the file: " + sfd1.FileName);
                                }
                            }
                        }
                    }
                    break;

                case "Font":
                    {
                        if (richTextBox1.SelectionFont != null)
                            fontDialog1.Font = richTextBox1.SelectionFont;
                        else
                            fontDialog1.Font = richTextBox1.Font;

                        if (fontDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if (richTextBox1.SelectionFont != null)
                                richTextBox1.SelectionFont = fontDialog1.Font;
                            else
                                richTextBox1.Font = fontDialog1.Font;
                        }
                    }
                    break;

                case "Color":
                    {
                        colorDialog1.Color = richTextBox1.SelectionColor;

                        if (colorDialog1.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SelectionColor = colorDialog1.Color;
                        }
                    }
                    break;
            }

            UpdateToolbar(); //Update the toolbar buttons
        }

        private void richTextBox1_SelectionChanged(object sender, System.EventArgs e)
        {
            if (!richTextBox1.InternalUpdating)
                UpdateToolbar(); //Update the toolbar buttons
        }

        /// <summary>
        ///     Update the toolbar button statuses
        /// </summary>
        public void UpdateToolbar()
        {
            //This is done incase 2 different fonts are selected at the same time
            //If that is the case there is no selection font so I use the default
            //font instead.
            Font fnt;

            if (richTextBox1.SelectionFont != null)
                fnt = richTextBox1.SelectionFont;
            else
                fnt = richTextBox1.Font;

            //Do all the toolbar button checks
            tbbBold.Pushed = fnt.Bold; //bold button
            tbbItalic.Pushed = fnt.Italic; //italic button
            tbbUnderline.Pushed = fnt.Underline; //underline button
            tbbStrikeout.Pushed = fnt.Strikeout; //strikeout button
            tbbLeft.Pushed = (richTextBox1.SelectionAlignment == HorizontalAlignment.Left); //justify left
            tbbCenter.Pushed = (richTextBox1.SelectionAlignment == HorizontalAlignment.Center); //justify center
            tbbRight.Pushed = (richTextBox1.SelectionAlignment == HorizontalAlignment.Right); //justify right

            tbbSuperScript.Pushed = richTextBox1.IsSuperScript();
            tbbSubScript.Pushed = richTextBox1.IsSubScript();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var from = "user@domain.com";
                var to = "user@domain.com";
                var subject = txtBoxSubject.Text;
                var message = richTextBox1.Text; //"<b>Testing using SMTP</b>";
                MailMessage mail = new MailMessage(from, to, subject, message);
                mail.IsBodyHtml = true;
                //SmtpClient client = new SmtpClient("localhost");

                SmtpClient client = new SmtpClient();
                client.Host = "domain";//txtServer.Text; //Set your smtp host address
                client.Port = 25;//int.Parse(txtPort.Text); // Set your smtp port address
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential(from, "pwd"); //account name and password
                client.EnableSsl = true; // Set SSL = true
                client.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
