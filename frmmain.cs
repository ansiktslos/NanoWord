using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NotepadCSharp
{
	
	public class frmmain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuNew;
		private System.Windows.Forms.MenuItem mnuOpen;
		private System.Windows.Forms.MenuItem mnuSave;
		private System.Windows.Forms.MenuItem mnuExit;
		private System.Windows.Forms.MenuItem mnuEdit;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuItem mnuCut;
		private System.Windows.Forms.MenuItem mnuCopy;
		private System.Windows.Forms.MenuItem mnuPaste;
		private System.Windows.Forms.MenuItem mnuDelete;
		private System.Windows.Forms.MenuItem mnuSelectAll;
		private System.Windows.Forms.MenuItem mnuHelp;
		private System.Windows.Forms.MenuItem mnuAbout;
	

		private System.Windows.Forms.MenuItem mnuArrangeIcons;
		private System.Windows.Forms.MenuItem mnuCascade;
		private System.Windows.Forms.MenuItem mnuTileHorizontal;
		private System.Windows.Forms.MenuItem mnuTileVertical;
		private System.Windows.Forms.MenuItem mnuWindow;
		private int openDocuments = 0;
		private System.Windows.Forms.MenuItem mnuFormat;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.MenuItem mnuSaveAs;
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.MenuItem mnuFont;
		private System.Windows.Forms.MenuItem mnuColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuFind;
		private System.Windows.Forms.ToolBarButton tbNew;
		private System.Windows.Forms.ToolBarButton tbOpen;
		private System.Windows.Forms.ToolBarButton tbSave;
		private System.Windows.Forms.ToolBarButton tbCut;
		private System.Windows.Forms.ToolBarButton tbCopy;
		private System.Windows.Forms.ToolBarButton tbPaste;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBar toolBarMain;
		private ToolBarButton tbLeft;
		private ToolBarButton tbCenter;
		private ToolBarButton tbRight;
		private ToolBarButton tbMoon;
		private ToolBarButton tbSun;
		private System.ComponentModel.IContainer components;

		[System.ComponentModel.Browsable(false)]
		public System.Windows.Forms.HorizontalAlignment SelectionAlignment { get; set; }

		public frmmain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			mnuSave.Enabled = false;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuNew = new System.Windows.Forms.MenuItem();
			this.mnuOpen = new System.Windows.Forms.MenuItem();
			this.mnuSave = new System.Windows.Forms.MenuItem();
			this.mnuSaveAs = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.mnuEdit = new System.Windows.Forms.MenuItem();
			this.mnuCut = new System.Windows.Forms.MenuItem();
			this.mnuCopy = new System.Windows.Forms.MenuItem();
			this.mnuPaste = new System.Windows.Forms.MenuItem();
			this.mnuDelete = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.mnuSelectAll = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuFind = new System.Windows.Forms.MenuItem();
			this.mnuFormat = new System.Windows.Forms.MenuItem();
			this.mnuFont = new System.Windows.Forms.MenuItem();
			this.mnuColor = new System.Windows.Forms.MenuItem();
			this.mnuWindow = new System.Windows.Forms.MenuItem();
			this.mnuArrangeIcons = new System.Windows.Forms.MenuItem();
			this.mnuCascade = new System.Windows.Forms.MenuItem();
			this.mnuTileHorizontal = new System.Windows.Forms.MenuItem();
			this.mnuTileVertical = new System.Windows.Forms.MenuItem();
			this.mnuHelp = new System.Windows.Forms.MenuItem();
			this.mnuAbout = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.toolBarMain = new System.Windows.Forms.ToolBar();
			this.tbNew = new System.Windows.Forms.ToolBarButton();
			this.tbOpen = new System.Windows.Forms.ToolBarButton();
			this.tbSave = new System.Windows.Forms.ToolBarButton();
			this.tbCut = new System.Windows.Forms.ToolBarButton();
			this.tbCopy = new System.Windows.Forms.ToolBarButton();
			this.tbPaste = new System.Windows.Forms.ToolBarButton();
			this.tbLeft = new System.Windows.Forms.ToolBarButton();
			this.tbCenter = new System.Windows.Forms.ToolBarButton();
			this.tbRight = new System.Windows.Forms.ToolBarButton();
			this.tbMoon = new System.Windows.Forms.ToolBarButton();
			this.tbSun = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuFormat,
            this.mnuWindow,
            this.mnuHelp});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.menuItem5,
            this.mnuExit});
			this.mnuFile.Text = "&����";
			// 
			// mnuNew
			// 
			this.mnuNew.Index = 0;
			this.mnuNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.mnuNew.Text = "&�����";
			this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
			// 
			// mnuOpen
			// 
			this.mnuOpen.Index = 1;
			this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.mnuOpen.Text = "&�������";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// mnuSave
			// 
			this.mnuSave.Index = 2;
			this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.mnuSave.Text = "&���������";
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
			// 
			// mnuSaveAs
			// 
			this.mnuSaveAs.Index = 3;
			this.mnuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
			this.mnuSaveAs.Text = "��������� &���";
			this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.Text = "-";
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 5;
			this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.mnuExit.Text = "&�����";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuEdit
			// 
			this.mnuEdit.Index = 1;
			this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDelete,
            this.menuItem12,
            this.mnuSelectAll,
            this.menuItem1,
            this.mnuFind});
			this.mnuEdit.Text = "&��������";
			// 
			// mnuCut
			// 
			this.mnuCut.Index = 0;
			this.mnuCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
			this.mnuCut.Text = "��������&";
			this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
			// 
			// mnuCopy
			// 
			this.mnuCopy.Index = 1;
			this.mnuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.mnuCopy.Text = "&����������";
			this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
			// 
			// mnuPaste
			// 
			this.mnuPaste.Index = 2;
			this.mnuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.mnuPaste.Text = "&��������";
			this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
			// 
			// mnuDelete
			// 
			this.mnuDelete.Index = 3;
			this.mnuDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.mnuDelete.Text = "&�������";
			this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 4;
			this.menuItem12.Text = "-";
			// 
			// mnuSelectAll
			// 
			this.mnuSelectAll.Index = 5;
			this.mnuSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
			this.mnuSelectAll.Text = "&������� ���";
			this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 6;
			this.menuItem1.Text = "-";
			// 
			// mnuFind
			// 
			this.mnuFind.Index = 7;
			this.mnuFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.mnuFind.Text = "&�����";
			this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
			// 
			// mnuFormat
			// 
			this.mnuFormat.Index = 2;
			this.mnuFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFont,
            this.mnuColor});
			this.mnuFormat.Text = "�&�����";
			// 
			// mnuFont
			// 
			this.mnuFont.Index = 0;
			this.mnuFont.Text = "�����...";
			this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
			// 
			// mnuColor
			// 
			this.mnuColor.Index = 1;
			this.mnuColor.Text = "����...";
			this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
			// 
			// mnuWindow
			// 
			this.mnuWindow.Index = 3;
			this.mnuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuArrangeIcons,
            this.mnuCascade,
            this.mnuTileHorizontal,
            this.mnuTileVertical});
			this.mnuWindow.Text = "&����";
			// 
			// mnuArrangeIcons
			// 
			this.mnuArrangeIcons.Index = 0;
			this.mnuArrangeIcons.MdiList = true;
			this.mnuArrangeIcons.Text = "����������� ������";
			// 
			// mnuCascade
			// 
			this.mnuCascade.Index = 1;
			this.mnuCascade.Text = "��������";
			this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
			// 
			// mnuTileHorizontal
			// 
			this.mnuTileHorizontal.Index = 2;
			this.mnuTileHorizontal.Text = "��������� �������������";
			this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click);
			// 
			// mnuTileVertical
			// 
			this.mnuTileVertical.Index = 3;
			this.mnuTileVertical.Text = "��������� �����������";
			this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.Index = 4;
			this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout});
			this.mnuHelp.Text = "?";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Index = 0;
			this.mnuAbout.Text = "� ���������...";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "��������� �����";
			this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "��������� �����";
			this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
			// 
			// toolBarMain
			// 
			this.toolBarMain.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbNew,
            this.tbOpen,
            this.tbSave,
            this.tbCut,
            this.tbCopy,
            this.tbPaste,
            this.tbLeft,
            this.tbCenter,
            this.tbRight,
            this.tbMoon,
            this.tbSun});
			this.toolBarMain.DropDownArrows = true;
			this.toolBarMain.ImageList = this.imageList1;
			this.toolBarMain.Location = new System.Drawing.Point(0, 0);
			this.toolBarMain.Name = "toolBarMain";
			this.toolBarMain.ShowToolTips = true;
			this.toolBarMain.Size = new System.Drawing.Size(477, 28);
			this.toolBarMain.TabIndex = 1;
			this.toolBarMain.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarMain_ButtonClick);
			// 
			// tbNew
			// 
			this.tbNew.ImageIndex = 0;
			this.tbNew.Name = "tbNew";
			this.tbNew.ToolTipText = "�������";
			// 
			// tbOpen
			// 
			this.tbOpen.ImageIndex = 1;
			this.tbOpen.Name = "tbOpen";
			this.tbOpen.ToolTipText = "�������";
			// 
			// tbSave
			// 
			this.tbSave.ImageIndex = 2;
			this.tbSave.Name = "tbSave";
			this.tbSave.ToolTipText = "���������";
			// 
			// tbCut
			// 
			this.tbCut.ImageIndex = 3;
			this.tbCut.Name = "tbCut";
			this.tbCut.ToolTipText = "��������";
			// 
			// tbCopy
			// 
			this.tbCopy.ImageIndex = 4;
			this.tbCopy.Name = "tbCopy";
			this.tbCopy.ToolTipText = "����������";
			// 
			// tbPaste
			// 
			this.tbPaste.ImageIndex = 5;
			this.tbPaste.Name = "tbPaste";
			this.tbPaste.ToolTipText = "��������";
			// 
			// tbLeft
			// 
			this.tbLeft.ImageIndex = 6;
			this.tbLeft.Name = "tbLeft";
			this.tbLeft.ToolTipText = "�� ������ ����";
			// 
			// tbCenter
			// 
			this.tbCenter.ImageIndex = 7;
			this.tbCenter.Name = "tbCenter";
			this.tbCenter.ToolTipText = "�� ������";
			// 
			// tbRight
			// 
			this.tbRight.ImageIndex = 8;
			this.tbRight.Name = "tbRight";
			this.tbRight.ToolTipText = "�� ������� ����";
			// 
			// tbMoon
			// 
			this.tbMoon.ImageIndex = 9;
			this.tbMoon.Name = "tbMoon";
			// 
			// tbSun
			// 
			this.tbSun.ImageIndex = 10;
			this.tbSun.Name = "tbSun";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "");
			this.imageList1.Images.SetKeyName(1, "");
			this.imageList1.Images.SetKeyName(2, "");
			this.imageList1.Images.SetKeyName(3, "");
			this.imageList1.Images.SetKeyName(4, "");
			this.imageList1.Images.SetKeyName(5, "");
			this.imageList1.Images.SetKeyName(6, "Left.jpg");
			this.imageList1.Images.SetKeyName(7, "Center.jpg");
			this.imageList1.Images.SetKeyName(8, "Right.jpg");
			this.imageList1.Images.SetKeyName(9, "Moon.jpg");
			this.imageList1.Images.SetKeyName(10, "Sun.jpg");
			// 
			// frmmain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(477, 331);
			this.Controls.Add(this.toolBarMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "frmmain";
			this.Text = "������ Soft";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmmain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new frmmain());
		}

		
		private void mnuNew_Click(object sender, System.EventArgs e)
		{
			//������� ����� ��������� �����  frm
			blank  frm = new blank();

			frm.DocName = "��� �������� " + ++openDocuments;
			//���������, ��� ������������ ����������� 
			//������ ���������� ����� ���, ������� �����.
			frm.MdiParent = this;
			frm.Text = frm.DocName;
			//�������� �����
			frm.Show();
		}

		private void mnuArrangeIcons_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
		}

	

		private void mnuCascade_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}

		private void mnuTileHorizontal_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void mnuTileVertical_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void mnuCut_Click(object sender, System.EventArgs e)
		{
			blank frm = (blank)this.ActiveMdiChild;
			frm.Cut();
		}

		private void mnuCopy_Click(object sender, System.EventArgs e)
		{
			blank frm = (blank)this.ActiveMdiChild;
			frm.Copy();
		}

		private void mnuPaste_Click(object sender, System.EventArgs e)
		{
			blank frm = (blank)this.ActiveMdiChild;
			frm.Paste();
		}

		private void mnuDelete_Click(object sender, System.EventArgs e)
		{
			blank frm = (blank)this.ActiveMdiChild;
			frm.Delete();
		}

		private void mnuSelectAll_Click(object sender, System.EventArgs e)
		{
			blank frm = (blank)this.ActiveMdiChild;
			frm.SelectAll();
		}

		private void mnuOpen_Click(object sender, System.EventArgs e)
		{
			//����� ���������� �������� ��������� ��� ������ ���������� ������. 
			//openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
			
			
			//���� ������ ������ �������� �����, ��������� �������
			if (openFileDialog1.ShowDialog() == DialogResult.OK) 
			{
				//������� ����� ��������
				blank frm = new blank();
				//�������� ����� Open ����� blank
				frm.Open(openFileDialog1.FileName);
				//���������, ��� ������������ ������ �������� ����� frmmain
				frm.MdiParent = this;
				//����������� ���������� DocName ��� ������������ �����
				frm.DocName = openFileDialog1.FileName;
				//�������� Text ����� ����������� ���������� DocName
				frm.Text = frm.DocName;
				//�������� ����� frm
				frm.Show();	
				mnuSave.Enabled = true;
			}
		

	

		
		}

		private void mnuSave_Click(object sender, System.EventArgs e)
		{
			//����������� ����� �� ������ �����.
			blank frm = (blank)this.ActiveMdiChild;
			//�������� ����� Save ����� blank
			frm.Save(frm.DocName);
			frm.IsSaved = true;
			
			
		}

		private void mnuSaveAs_Click(object sender, System.EventArgs e)
		{
			mnuSave.Enabled = true;
			//����� ���������� �������� ��������� ��� ������ ���������� ������. 
			//openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";

			//���� ������ ������ �������� �����, ��������� �������
			if (saveFileDialog1.ShowDialog() == DialogResult.OK) 
			{
				//����������� ����� �� ������ �����.
				blank frm = (blank)this.ActiveMdiChild;
				//�������� ����� Save ����� blank
				frm.Save(saveFileDialog1.FileName);
				//���������, ��� ������������ ������ �������� ����� frmmain
				frm.MdiParent = this;
				//����������� ���������� FileName ��� ������������ �����
				frm.DocName = saveFileDialog1.FileName;
				//�������� Text ����� ����������� ���������� DocName
				frm.Text = frm.DocName;		
				frm.IsSaved = true;
				
		
			}

	
		}

		private void mnuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void mnuFont_Click(object sender, System.EventArgs e)
		{
			//����������� ����� �� ������ �����.
			blank  frm = (blank)this.ActiveMdiChild;
			//���������, ��� ������������ ������ �������� ����� frmmain	
			frm.MdiParent = this;
			//�������� ������
			fontDialog1.ShowColor = true;
			//��������� �������� SelectionFont � SelectionColor �������� RichTextBox 
			//� ���������������� ���������� �������
			fontDialog1.Font = frm.richTextBox1.SelectionFont;
			fontDialog1.Color = frm.richTextBox1.SelectionColor; 
			//���� ������ ������ �������� �����, ��������� �������
			if (fontDialog1.ShowDialog() == DialogResult.OK)
			{
				frm.richTextBox1.SelectionFont = fontDialog1.Font;
				frm.richTextBox1.SelectionColor = fontDialog1.Color; 
			}
			//���������� �����
			frm.Show();
		}

		private void mnuColor_Click(object sender, System.EventArgs e)
		{
			blank frm = (blank)this.ActiveMdiChild;
			frm.MdiParent = this;
			colorDialog1.Color = frm.richTextBox1.SelectionColor; 
			
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				frm.richTextBox1.SelectionColor = colorDialog1.Color; 
			}

			frm.Show();
		}

		
		private void mnuFind_Click(object sender, System.EventArgs e)
		{
			//������� ����� ��������� ����� FindForm
			FindForm frm = new FindForm();
			//���� ������ ��������� DialogResult.Cancel, ��������� ����� (�� ����� 
			//�� ������������ DialogResult.OK
			if(frm.ShowDialog(this) == DialogResult.Cancel) return;
			////����������� ����� �� ������ �����.
			blank form = (blank)this.ActiveMdiChild;
			////���������, ��� ������������ ������ �������� ����� frmmain	
			form.MdiParent = this;
			//������ ���������� ��� ������ � ������������ ����� ������ -
			//����� ����� ����� �������������� �� ������� ������� �������
			int start = form.richTextBox1.SelectionStart;
			//�������� ���������������� ����� Find �������� richTextBox1.
			form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
		}

		private void mnuAbout_Click(object sender, System.EventArgs e)
		{
			//������� ����� ��������� �����  About
			About  frm = new About();
			frm.Show();
		}

		private void toolBarMain_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			blank frm = (blank)this.ActiveMdiChild;
			//New
			if (e.Button.Equals(tbNew)) 
			{
				mnuNew_Click(this, new EventArgs());
			}
			//Open
			if (e.Button.Equals(tbOpen))
			{
				mnuOpen_Click(this, new EventArgs());
			}
			//Save
			if (e.Button.Equals(tbSave))
			{
				mnuSave_Click(this, new EventArgs());
			}
			//Cut
			if (e.Button.Equals(tbCut))
			{
				mnuCut_Click(this, new EventArgs());
			}
			//Copy
			if (e.Button.Equals(tbCopy))
			{
				mnuCopy_Click(this, new EventArgs());
			}
			//Paste
			if (e.Button.Equals(tbPaste))
			{
				mnuPaste_Click(this, new EventArgs());
			}
			//Left
			if (e.Button.Equals(tbLeft))
			{
				//����� �� ������ ����
				frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
			}
			//Center
			if (e.Button.Equals(tbCenter))
			{
				//����� �� ������
				frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
			}
			//Right
			if (e.Button.Equals(tbRight))
			{
				//����� �� ������� ����
				frm.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
			}
			//Moon
			if (e.Button.Equals(tbMoon))
			{
				string rtbText = frm.richTextBox1.Text;
				frm.richTextBox1.ForeColor = Color.White;
				for (int i = 0; i < rtbText.Length; i++)
				{
					if (rtbText[i] >= 'A' && rtbText[i] <= 'Z')
					{
						frm.richTextBox1.Select(i, 1);
						frm.richTextBox1.SelectionColor = Color.White;
					}
				}
				frm.richTextBox1.BackColor = Color.Black;
			}
			//Sun
			if (e.Button.Equals(tbSun))
			{
				string rtbText = frm.richTextBox1.Text;
				frm.richTextBox1.ForeColor = Color.Black;
				for (int i = 0; i < rtbText.Length; i++)
				{
					if (rtbText[i] >= 'A' && rtbText[i] <= 'Z')
					{
						frm.richTextBox1.Select(i, 1);
						frm.richTextBox1.SelectionColor = Color.Black;
					}
				}
				frm.richTextBox1.BackColor = Color.White;
			}

		}

		private void frmmain_Load(object sender, EventArgs e)
		{

		}

		private void menuItem2_Click(object sender, EventArgs e)
		{

		}
	}
}