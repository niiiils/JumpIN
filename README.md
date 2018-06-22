# JumpIN

### Built with Xamarin & Firebase

The Swiss Post organizes a camp every year to introduce their new interns & apprentices to the company.

##### Creating a new menu item

Use the method `createMenuItem` in the main method of **MainPage.xaml.cs** in order to add a new item to the menu.

###### Parameters

1. image     *this is the name of the image that can be found in the Resources directory*
2. textColor *either "Black" or "White" in order to create a contrast"*
3. text      *this is the text on the menu item; It is formatted for 2-line-phrases*

###### Example

```
public MainPage()
        {
            InitializeComponent();
            createMenuItem("aletsch.jpg", "White", "Write a little story about yourself!");
            createMenuItem("wanderung1.jpg", "White", "Immatriculate yourself for an event!");
            createMenuItem("galerie1.jpg", "White", "See pictures that were taken at this camp!");
            loadDate();
        }
```
