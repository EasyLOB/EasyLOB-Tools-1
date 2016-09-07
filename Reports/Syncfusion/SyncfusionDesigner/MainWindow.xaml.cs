#region Copyright Syncfusion Inc. 2001-2015.

// Copyright Syncfusion Inc. 2001-2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws.

#endregion Copyright Syncfusion Inc. 2001-2015.

using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Company_Sales_2008
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Syncfusion.SfSkinManager.SfSkinManager.SetVisualStyle(this, VisualStyles.Metro);
            this.Title = "Syncfusion Essential Report Designer";
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // @@@
            //string path = @"../../../ReportTemplate/Sales Dashboard.rdl";
            //this.ReportDesignerControl.OpenReport(path);
            //this.ReportDesignerControl.ShowProperties = false;
        }

        private void ComboBoxAdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItemAdv item;
            WindowCollection windows = Application.Current.Windows;
            if (windows.Count > 0)
            {
                Window samplewindow = windows[0];
                ComboBoxAdv combo = sender as ComboBoxAdv;
                if (combo != null)
                {
                    if (combo.SelectedItem != null)
                    {
                        item = combo.SelectedItem as ComboBoxItemAdv;
                        if (this.ReportDesignerControl != null)
                        {
                            Syncfusion.SfSkinManager.SfSkinManager.SetVisualStyle(this, (VisualStyles)Enum.Parse(typeof(VisualStyles), item.Content.ToString()));
                            this.ReportDesignerControl.VisualStyle = Syncfusion.SfSkinManager.SfSkinManager.GetVisualStyle(this).ToString();
                        }
                    }
                }
            }
        }
    }
}