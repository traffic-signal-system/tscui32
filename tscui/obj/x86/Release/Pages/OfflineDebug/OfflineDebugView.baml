   M S B A M L   `   `   `  ���� K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:tscui.Pages.OfflineDebugtscui.Pages.OfflineDebug /   )tscui.Pages.OfflineDebug.OfflineDebugView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     BapexControls)clr-namespace:Apex.Controls;assembly=Apex     8local&clr-namespace:tscui.Pages.OfflineDebug       � DataContext  4  .tscui.Pages.OfflineDebug.OfflineDebugViewModel  -   	viewModel��.���� $��0,4,40,4q�$��Disabled=�$
��Auto=�.��   Apex.Controls.ApexGrid  $��40,0,0,0q�   Rows$( "Auto,Auto,Auto,Auto,Auto,Auto,Auto��.+��� -   $��	groupBox1��$!��离线调试信号机数据��$	��543��$
��Left=�$	��Top=�$	��708��.��� -    J� 	AllowDrop . .+��� -   $��label18��$�� ��$��28��$
��Left=�$��	12,30,0,0q�$	��Top=��� -   $��Startdebugbtn��$��启动离线调试 ��$��23��$
��Left=�$��
54,140,0,0q�$	��Top=�$	��159������ *DegradationCommand1+�� -    ��Name$ datafilename��$B��<加载离线数据文件-> 鼠标拖动数据文件到这里�� � ToolTip$ 拖动文件到这里��$
��Left=�$��	88,60,0,0q�$	��Top=�$	��529��#��� ���� -    ��Name$ Savedatabtn��$��导出离线数据��$��23��$
��Left=�$��
54,206,0,0q�$	��Top=�$	��159������ *DegradationCommand1+�� -   $ CloseDebugbtn��$��关闭离线调试 ��$��23��$
��Left=�$��
54,271,0,0q�$	��Top=�$	��159������ *DegradationCommand1+�� $
��Left=�$��
54,332,0,0q�$
��Wrap=�$	��Top=�$	��166��$	��500��#��� ���� .�操作说明:�� �� .���1. 可点击打开按钮选择数据文件或者鼠标拖动数据文件到加载离线数据文件标签处，文字标签将显示待加载的文件名。系统会提示是否加载成功！为确保数据不受之前操作干扰,加载前可点击关闭离线调试按钮！�� �� .���2. 数据文件加载成功后，点击启动离线调试按钮。提示启动成功后，去主界面刷新信号机，将会看到IP为127.0.0.1离线信号机IP。选择后可进行离线数据操作,观察。�� �� .�SQ3. 离线数据操作完成后，点击导出离线数据，保存数据文件。�� �� .�534. 上述操作完毕，点击关闭离线调试。�� $
��Left=�$��35��$��	52,56,0,0q�$	��Top=�$��36��$0��*/tscui;component/Resources/Images/file.png���� -	   $��打开��$
��Left=�$��
620,61,0,0q�$	��Top=�$��53��