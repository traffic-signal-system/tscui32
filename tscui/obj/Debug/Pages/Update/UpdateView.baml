   M S B A M L   `   `   `  ����K  GApex, Version=1.5.0.0, Culture=neutral, PublicKeyToken=98d06957926c086d;)clr-namespace:Apex.Controls;assembly=ApexApex.Controls  5      @ <tscui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:tscui.Pages.Updatetscui.Pages.Update 5      #   tscui.Pages.Update.UpdateView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      BapexControls)clr-namespace:Apex.Controls;assembly=Apex     5      2local clr-namespace:tscui.Pages.Update     5      -   5          � DataContext  5      (  "tscui.Pages.Update.UpdateViewModel  5   
   -   5        	viewModel��5       .��5         Apex.Controls.ApexGrid  
������ .+�5   
   �� $
��Left=�6   $��
54,326,0,0q�6/   #��� ��6C   $
��Wrap=�6�   $	��Top=�6�   $	��184��6�   $	��359��6�   �� 5      $��14(�6   $4�.更新程序文件或数据文件操作说明:��6    �� 5      �� 5      �� 6   $N�H1. 点击刷新按钮可显示当前信号机下程序和数据文件！��6   �� 6B   �� 5      $���2. 更新操作前建议备份文件，选中列表中正确的程序或者数据文件，右键弹出菜单选择备份。备份文件名以bak结尾。如果需要恢复备份文件，右键选择备份文件弹出菜单选择恢复即可。!��6   �� 6r   �� 5      
���� ��$���3. 更新操作如果需要本地上传文件，可点击上传按钮，选择要上传的程序或者数据文件，其他文件类型不支持!上传成功后需要重启信号机。��6&   �� 6p   �� 5      $I�C4. 列表文件也可右键菜单选择下载或者删除文件 。��6   �� 65   5      � 5   
   $
��Left=�6   $	��326��6*   $	��Top=�67   $	��790��6O   $��0,10,0,0q�6[   .+�5      �� -   5         ��Name$ FileListBox��5   +    �� AlternationCount$ 2��6   $
��Left=�6@   $	��164��6[   $��	58,68,0,0q�6h   $	��Top=�6{   $	��351��6�    J� IsManipulationEnabled .  � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ DownLoadFile��5   #   $��下载��69   6E   m� 5      -   5        $ 
DeleteFile��5   #   $��删除��67   6E   m� 5      -   5        $ BackFile��5   #   $��备份��65   6E   m� 5       -   5        $ RecoverFile��5    #   $��恢复��68   6E   m� 5!      -   5        $ 
RestartTsc��5!   #   $��重启信号机��67   6H   5#      5%      �� 5&      $O��I信号机系统文件列表                                 系统密码:��6   $
��Left=�6N   $��	58,39,0,0q�6i   $	��Top=�6|   $	��279��6�   G� 5'      -	   5         G�Name$ Pwdbox��5'      $
��Left=�6*   $��
337,43,0,0q�6E   $	��Top=�6Y   $��72��6q    G� Password$
 root��6|   �� 5(      -
   5         ��Name$ RefreshBtnFile��5(      $��刷新��6-   $
��Left=�6:   $��
58,247,0,0q�6U   $	��Top=�6i   $��56��6�   	 J� RenderTransformOrigin$	 0.321,0.409&�6�   6�   �� 5)      -   5        $��上传��5)      $
��Left=�6"   $��158,247,0,0q�6=   $	��Top=�6R   $��56��6j   $	 0.5,0.5&�6u   6�   5*      5+      5-      