   M S B A M L   `   `   `  ���� K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:tscui.Pages.Updatetscui.Pages.Update #   tscui.Pages.Update.UpdateView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     2local clr-namespace:tscui.Pages.Update     -     � DataContext  (  "tscui.Pages.Update.UpdateViewModel  -   	viewModel��.��   Apex.Controls.ApexGrid  
������ .+��� $
��Left=�$��
54,326,0,0q�#��� ��$
��Wrap=�$	��Top=�$	��184��$	��359���� $��14(�$4�.更新程序文件或数据文件操作说明:���� �� �� $N�H1. 点击刷新按钮可显示当前信号机下程序和数据文件！���� �� $���2. 更新操作前建议备份文件，选中列表中正确的程序或者数据文件，右键弹出菜单选择备份。备份文件名以bak结尾。如果需要恢复备份文件，右键选择备份文件弹出菜单选择恢复即可。!���� �� 
���� ��$���3. 更新操作如果需要本地上传文件，可点击上传按钮，选择要上传的程序或者数据文件，其他文件类型不支持!上传成功后需要重启信号机。���� �� $I�C4. 列表文件也可右键菜单选择下载或者删除文件 。���� � $
��Left=�$	��326��$	��Top=�$	��790��$��0,10,0,0q�.+��� -    ��Name$ FileListBox�� �� AlternationCount$ 2��$
��Left=�$	��164��$��	58,68,0,0q�$	��Top=�$	��351�� J� IsManipulationEnabled .  � ContextMenu �� .@�m� -    m�Name$ DownLoadFile��$��下载��m� -   $ 
DeleteFile��$��删除��m� -   $ BackFile��$��备份��m� -   $ RecoverFile��$��恢复��m� -   $ 
RestartTsc��$��重启信号机���� $O��I信号机系统文件列表                                 系统密码:��$
��Left=�$��	58,39,0,0q�$	��Top=�$	��279��G� -	    G�Name$ Pwdbox��$
��Left=�$��
337,43,0,0q�$	��Top=�$��72�� G� Password$
 root���� -
    ��Name$ RefreshBtnFile��$��刷新��$
��Left=�$��
58,247,0,0q�$	��Top=�$��56��	 J� RenderTransformOrigin$	 0.321,0.409&��� -   $��上传��$
��Left=�$��158,247,0,0q�$	��Top=�$��56��$	 0.5,0.5&�