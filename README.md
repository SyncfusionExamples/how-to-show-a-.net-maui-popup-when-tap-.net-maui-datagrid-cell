# How to show a .NET MAUI Popup when tapping a .NET MAUI DataGrid cell
In this article, we will show you how to display a popup using Syncfusion .NET MAUI SfPopup when a user taps a cell in the Syncfusion .NET MAUI DataGrid (SfDataGrid). This pattern is useful for showing additional details, contextual actions, confirmations, or lightweight forms without navigating away from the current page. The implementation is straightforward: wire up the DataGrid CellTapped event and call Show() on the SfPopup instance.

The sample uses a simple ViewModel as BindingContext for the page and demonstrates the following:
- Declaring SfDataGrid and SfPopup in XAML
- Handling the DataGrid CellTapped event in code-behind
- Opening the popup programmatically with a single line of code
- Recommended layout and configuration tips

## XAML
```xml
    <ContentPage.BindingContext>
        <local:ViewModel x:Name="viewModel" />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <Grid>
            <sfDatagrid:SfDataGrid x:Name="dataGrid"
                                   ItemsSource="{Binding OrdersInfo}"
                                   CellTapped="DataGrid_CellTapped"
                                   ColumnWidthMode="Fill">
            </sfDatagrid:SfDataGrid>

            <sfPopup:SfPopup x:Name="sfPopup" 
                             HeaderTitle="Popup" 
                             AutoSizeMode="Height"
                             ShowCloseButton="True">
                <sfPopup:SfPopup.ContentTemplate>
                    <DataTemplate>
                        <Label Text="A pop-up is a graphical user interface display area that suddenly appears in the foreground of the visual interface. Pop-up can be initiated by single or double tap or can simply be timed to occur. A pop-up window should be smaller than the background window or interface; otherwise, its a replacement interface."                               
                               TextColor="Black" 
                               FontSize="14" 
                               FontFamily="Roboto" 
                               Padding="0,0,0,24" />
                    </DataTemplate>
                </sfPopup:SfPopup.ContentTemplate>
            </sfPopup:SfPopup>
        </Grid>
    </ContentPage.Content>
```

## C#
Handle the DataGrid cell tap and open the popup in code-behind:
```csharp
	private void DataGrid_CellTapped(object sender, Syncfusion.Maui.DataGrid.DataGridCellTappedEventArgs e)
	{
		sfPopup.Show();
	}
```

## How it works
- SfDataGrid raises the CellTapped event when the user taps any cell.
- In the event handler, we call sfPopup.Show() to display the popup.
- SfPopup is declared in the same page and can be styled or templated (HeaderTitle, button visibility, animations, AutoSizeMode, and more).

## References
- Syncfusion .NET MAUI DataGrid (SfDataGrid): https://www.syncfusion.com/maui-controls/maui-datagrid
- DataGrid documentation: https://help.syncfusion.com/maui/datagrid/overview
- Syncfusion .NET MAUI Popup (SfPopup): https://www.syncfusion.com/maui-controls/maui-popup
- SfPopup getting started: https://help.syncfusion.com/maui/popup/getting-started

##### Conclusion
 
I hope you enjoyed learning about how to show a .NET MAUI SfPopup when tap .NET MAUI DataGrid cell (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
