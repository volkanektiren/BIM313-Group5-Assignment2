# BIM313-Group5-Assignment2
BIM313 Advanced Programming Techniques course group project.

# Assignment Issues
-Create a C# .Net Form Application.
-Create a MainForm(or rename Form1) and add a button and a combobox.
-Insert options to combobox “Select”, “Circle” and “Rectangle”.(“Select” must be selected.)
-Create 3 labels, 3 textboxes in MainForm and hide them.
-These textboxes get values from user circle radius and rectangle edges.
-When combobox item Circle is selected, textboxRadius is visible, textboxEdge1 and textboxedge2 are hidden.
-When combobox item Rectangle is selected, textboxEdge1 and textboxEdge2 are visible, textboxRadius is hidden.
-Create RectangleForm and CircleForm. Each form has one button, one label and one picturebox.
-Create a property integer radius in CircleForm and create integer edge1, edge2 properties in RectangleForm.
-Button in Mainform redirects to CircleForm or RectangleForm with respect to combobox selected item.(CircleForm and RectangleForm are shown modal.)
-While redirecting mainform to circle/rectangle form, you have to pass textbox values.(Hint: properties in CircleForm/RectangleForm)
-Create interface IShape which has CalculateArea and CalculatePerimeter methods.
-These methods return double value.
-Create class Shape which has Print method. Print method takes 2 double parameter.(Area and Perimeter) and return string Area and Perimeter info. message.
-Create class CircleShape and RectangleShape which implement IShape interface and Shape class.
-CircleShape and RectangleShape classes have constructor that takes parameter radius/edges.
-Button in CircleForm and RectangleForm calculates the area and perimeter. Then set label text to these message and draw shape to form.(Hint: Use Circle/Rectangle class). Draw circle or rectangle to picturebox with respect to radius or edge1,edge2 values when button clicked.
-For each Rectangle and Circle Form, the picturebox will be used to draw a circle or rectangle. You have to draw a circle or rectangle while clicking the mouse on the picturebox and moving on it. The drawing should now be finished when the mouse click is released. And perimeter/area calculations should be done and written in the text box when the mouse click is released.
-Note : For convenience, you can draw an ellipse instead of a circle.
-Your program should be similar to below layout. Selecting "Circle" or "Rectangle" will follow different paths.

# Assignment Screens
![Image of Screens](https://github.com/volkanektiren/BIM313-Group5-Assignment2/blob/main/Screens.png)
