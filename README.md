# hyacinthuslux🌸

The Hyacinthus Lux project is a user-friendly application designed to manage client and product information for a flower shop. It includes essential functionalities for:

#### Data Management: Easily add, update, and delete client and product details.
#### Data Validation: Ensure the accuracy and completeness of information entered.
#### Serialization: Save and load data in different formats.
#### Reporting: Generate and export reports.
#### Graphical Representation: Display data in charts for better visualization.

This application helps streamline business operations, making it easier to keep track of clients and products effectively.

### Client Class Attributes

The `Client` class represents a customer of the flower shop, storing essential personal and contact information. Below are the attributes defined in the `Client` class:

- **clientId**: An integer that serves as the unique identifier for each client.
- **clientFirstName**: A string storing the first name of the client.
- **clientLastName**: A string storing the last name of the client.
- **clientEmail**: A string storing the email address of the client.
- **clientAddress**: A string storing the physical address of the client.
- **clientPhoneNumber**: A string storing the client's phone number.
- **clientLoyaltyPoints**: A double representing the loyalty points accumulated by the client.

##### Properties

FullName: A read-only string property that combines the first and last names of the client.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/68737645-6abe-4d0b-912f-2832682ca433)

##### Constructors

1. Parameterized Constructor: Initializes a new instance of the Client class with all attributes, including validation for the address and phone number. Throws exceptions for invalid values.
2. Parameterless Constructor: Initializes a new instance of the Client class without setting any attributes.

##### Methods

1. CompareTo: Compares the current client object with another client object based on their clientId. This is used for sorting and comparing clients.
2. ToString: Returns a string representation of the client, typically their full name.

##### Custom Exceptions

1. InvalidAddressException: Thrown when the client's address contains the word "Florida".
2. General Exception: Thrown for a specific invalid phone number.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/eb9a14ac-9fef-4887-9bef-88c9c2561ecd)

### Class: Product

Purpose: Represents the products available in the flower shop, storing details such as price, name, availability, type, and stock.

##### Attributes

- **productPrice**: A decimal representing the price of the product.
- **productName**: A string storing the name of the product.
- **IsAvailable**: A boolean indicating whether the product is available for purchase.
- **productType**: An enumeration (FlowerEnum) specifying the type of flower the product is associated with.
- **productStock**: An integer representing the quantity of the product in stock.

##### Properties

The attributes themselves serve as properties due to the use of auto-implemented properties in C#.

##### Constructors

1. Parameterless Constructor: Initializes a new instance of the Product class without setting any attributes.
2. Parameterized Constructor: Initializes a new instance of the Product class with specified values for price, name, availability, type, and stock.

##### Methods

Clone: Implements the ICloneable interface to create a copy of the current product instance. This method returns an object that is a clone of the current instance.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/3efc3210-0b34-4cdc-be3f-6bec48392cb0)

##### Integration with EnumFlower Class

The Product class integrates with the FlowerEnum class to specify the type of flower for each product. This integration ensures that each product can be categorized correctly, providing clear information about the type of flower it represents.

##### Enum: FlowerEnum

Purpose: Represents the different types of flowers that a product can be associated with. This enumeration ensures that the product type is restricted to a predefined set of values, enhancing data consistency and integrity.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/0e7e0e6f-f4ca-4093-af0f-0a8c31ff71ce)

## Class: Delivery

Purpose: Represents the delivery details for orders placed by clients, including client information, products, delivery location, date, and method. It calculates the total value of the delivery including transport costs.

##### Attributes

- **DeliveryClient**: A Client object representing the client who placed the order.
- **DeliveryProducts**: A List<Product> containing the products included in the delivery.
- **deliveryQuantities**: A List<int> representing the quantities of each product in the delivery.
- **deliveryLocation**: A string specifying the location to which the order is to be delivered.
- **deliveryDate**: A DateTime object representing the date the delivery is scheduled or was made.
- **deliveryMethod**: An EnumCourier.CourierEnum value representing the method of delivery chosen for the order.

##### Properties

1. **DeliveryTotalValue**: A decimal property that calculates the total value of all products in the delivery by multiplying each product's price by its quantity. Basically, it computes the subtotal of the delivery (without taking into account the cost for transportation/courier).
2. **Total**: A decimal property that returns the total value of the delivery, including transport costs.

##### Constructors

1. Parameterless Constructor: Initializes a new instance of the Delivery class with default values.
2. Parameterized Constructor: Initializes a new instance of the Delivery class with specified values for client, products, quantities, date, location, and delivery method.

##### Methods

1. **GetTotalValue**: Calculates the total value of the delivery by summing the product values and adding the transport cost based on the delivery method.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/1720c520-07ea-4686-98f7-9180e790c7ae)

2. **DeliveryConcatenatedProducts**: Creates a concatenated string representing the products and their quantities in the delivery.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/b7ab0f85-1dc5-46ab-b3eb-f8d9c709df13)

3. **ReturnCostBasedOnDeliveryMethod**: Determines the cost of delivery based on the chosen delivery method. It offers free delivery for orders over a certain value and provides specific costs for various courier services.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/a63a3b15-52a4-4e17-b166-5b75e5439364)

### Integration with Other Classes

The `Delivery` class is designed to work seamlessly with other classes in the application. Here's how it integrates:

1. **Client**: The `DeliveryClient` attribute holds a reference to a `Client` object, encapsulating all the client details required for the delivery.
2. **Product**: The `DeliveryProducts` attribute contains a list of `Product` objects, each representing a product in the delivery.
3. **EnumCourier**: The `deliveryMethod` attribute uses the `EnumCourier.CourierEnum` enumeration to specify the method of delivery, ensuring that only valid delivery methods are assigned.

## EnumCourier Class

Purpose: Represents the different courier methods available for deliveries.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ff05affc-a8c2-4553-8026-c20f53ebad4d)

This enum is used in the Delivery class to specify the delivery method, allowing for easy extension and maintenance of courier methods.

# Forms

## Class: Client_Form

The Client_Form class manages the user interface and functionalities for handling client data within the hyacinthuslux application. This form allows users to add, update, delete, and display client information.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/9dd00810-05cb-4c07-850f-4770af507c5e)

##### Attributes

- **ConnectionString**: A constant string used to connect to the SQLite database.
- **ErrorProvider errorProvider**: An instance of ErrorProvider used to provide validation feedback to the user.
- **List<Client> clients**: A list to hold the client data.

##### Constructor

Client_Form(): Initializes the form components and sets up the initial list of clients.

##### Methods

1. **Client_Form_Load**: Load the form, read client data from the database, and display it.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/c47fb3aa-d802-42e0-aa15-31e8cb3a9e9f)

2. **createClient**: Insert a new client into the database.
3. **deleteClient**: Delete a client from the database by ID.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/53e2e615-820c-470e-933c-afd1e7ae69af)

4. **ReadClient**: Read all clients from the database and store them in the clients list.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/86268413-eddb-46f9-9aae-ca9cfa7a8d55)

5. **DisplayParticipants**: Display the list of clients in the ListView control.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ca0be431-a534-4112-b70f-b4013edfbc64)

6. **updateClient**: Update an existing client in the database.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/9a4dc126-6af5-4da9-951b-a13325533d70)

7. **ResetForm**: Reset the form fields to their default values.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/e07793c2-8074-4941-9111-56c416fee57e)

##### Event Handlers

1. **bntAdd_Click**: Add a new client to the list and database.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/c76cded5-1ed9-4424-980f-f5ad637c23d1)

2. **btnSaveClient_Click**: Save the changes made to an existing client.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/1f88fc13-5872-4623-a96d-5dd395e4b0e8)

3. **btnDeleteClient_Click**: Delete a selected client from the list and database.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/d3b889a6-8632-4de2-a1ba-64da7e8b9d3b)

4. **lvClients_MouseDoubleClick**: Load the selected client details into the form fields for editing.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/003a8d2a-e851-4481-8a0f-6ed1c2a95339)

5. **tbPhoneNumber_Validating**: Validate the phone number field to ensure it is not empty and has a valid length.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/eb936694-3841-496d-9f40-1b79e4aac8c3)

6. **tbLastName_Validating**: Validate the last name field to ensure it meets certain criteria.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/40c983c9-98c7-4cbe-8a17-5d8a7d79630c)

7. **tbAddress_Validating**: Validate the address field to ensure it contains a comma and is not empty or whitespace.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/bb8c2ff6-a8e0-4050-a6c9-cf20fa1e04bb)

8. **tbEmail_Validating**: Validate the email field to ensure it contains an "@" symbol and is not empty or whitespace.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/42e0b200-13fe-4349-aa27-327de1616e88)

9. **numLoy_Validating**: Validate the loyalty points field to ensure it is not greater than 99.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/a9916a69-4e24-4693-b652-6be20375ffd8)

10. **Serialization and Deserialization**: 
   - **serializeToolStripMenuItem_Click**: Serialize the client list to a binary file.
   - **deserializeToolStripMenuItem_Click**: Deserialize the client list from a binary file.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/dc6e71c2-86ca-4a01-a0da-c5a1aeacd6bc)

   - **serializeXMLToolStripMenuItem_Click**: Serialize the client list to an XML file.
   - **deserializeXMLToolStripMenuItem_Click**: Deserialize the client list from an XML file.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ea4baec3-c2a1-4cee-910f-ad147bbe5996)

11. **Clipboard Operations**:
   - **btnCopy_Click**: Copy the first name to the clipboard.
   - **btnPaste_Click**: Paste the text from the clipboard to the first name field.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/6718a6be-36b3-4141-8091-1fd8be06b006)

12. **Drag and Drop Operations**:
   - **tbPhoneNumber_MouseDown**: Initiate a drag-and-drop operation with the phone number.
   - **tbPhoneNumber_DragEnter**: Allow a copy effect if the data format is text.
   - **tbPhoneNumber_DragDrop**: Handle the drop event to set the phone number text.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/22484e16-394a-46b9-9042-082922136f0d)

13. **Export to TXT**:
   - **ExportReportAsTxt**: Export client data to a TXT file.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/ff720a8a-a28f-4cd2-9252-29ef85afca69)

## Class: Product_Form

The Product_Form class manages the user interface and functionalities for handling product data within the hyacinthuslux application. This form allows users to add, update, delete, display, serialize, and print product information. Below is a comprehensive breakdown of its methods, buttons, and functionality.

##### Attributes

- **ConnectionString**: A constant string used to connect to the SQLite database.
- **PrintDocument printDocument**: An instance of PrintDocument used for printing product information.
- **ErrorProvider errorProvider**: An instance of ErrorProvider used to provide validation feedback to the user.
- **List<Product> products**: A list to hold the product data.

##### Constructor

Product_Form(): Initializes the form components, sets up the print document event, and initializes the product list.

##### Methods

1. **Product_Form_Load**: Load the form, populate the product type dropdown, read product data from the database, and display it.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/8069d593-d50c-4284-89bb-e6ced684b310)

2. **createProduct**: Insert a new product into the database.
3. **readProduct**: Read all products from the database and store them in the products list.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/db207101-beba-4b9a-8d60-673d98228a74)

4. **updateProduct**: Update an existing product in the database.
5. **ResetForm**: Reset the form fields to their default values.
6. **DisplayProducts**: Display the list of products in the ListView control.
7. **DeleteProduct**: Deletes the product from the database based on primary key @productName.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/0a8472e5-31e7-4ef9-b08f-fb19f44aac2c)

##### Event Handlers

1. **btnAdd_Click**: Add a new product to the list and database.
2. **btnSave_Click**: Save the changes made to an existing product.
3. **btnDeleteProduct_Click**: Delete a selected product from the list and database.
4. **DeleteProduct**: Delete a product from the database by name.
5. **lvProducts_MouseDoubleClick**: Load the selected product details into the form fields for editing.
6. **tbTitle_Validating**: Validate the title field to ensure it is not empty, whitespace, or too short.
7. **tbPrice_Validating**: Validate the price field to ensure it is within a valid range.
8. **numStock_Validating**: Validate the stock field to ensure it does not exceed a maximum value.
9. **SerializeBinary_Click**: Serialize the product list to a binary file.
10. **DeserializeBinary_Click**: Deserialize the product list from a binary file.
11. **SerializeXMLToolStripMenuItem_Click**: Serialize the product list to an XML file.
12. **DeserializeXMLToolStripMenuItem_Click**: Deserialize the product list from an XML file.
13. **PrintDocument_PrintPage**: Handle the print page event to print the product list.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/f2aecc10-bde6-4ee2-8488-d93359379d4c)

###### NB: The `PrintDocument_PrintPage` method captures the visual representation of the `lvProducts` `ListView` control and draws it onto a `PrintDocument` at specified coordinates (50, 50). It starts by creating a new `Bitmap` object with dimensions matching the `lvProducts` control. A `Bitmap` is an in-memory representation of an image, which allows for drawing operations to be performed on it. The method then draws the `lvProducts` control onto this bitmap using the `DrawToBitmap` method, which takes the bitmap and a `Rectangle` specifying the area of the control to be drawn. Finally, the bitmap is printed onto the print document at the specified location using the `DrawImage` method of the `Graphics` object. 

14. **buttonPrintPreview_Click**: Show a print preview of the product list.

The `buttonPrintPreview_Click` method sets up and displays a print preview dialog for the `PrintDocument`, allowing the user to see how the `ListView` will look when printed. It creates a new instance of `PrintPreviewDialog`, sets its `Document` property to `printDocument`, and then displays the dialog as a modal dialog box, waiting for the user to take an action such as clicking "Print" or "Close".

15. **btnCancel_Click**: Close the form.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/003a8d2a-e851-4481-8a0f-6ed1c2a95339)



## Delivery Form

The `Delivery_Form` class is designed to manage the delivery process within the `hyacinthuslux` application. This form allows users to create, update, and display delivery information, including details about the client, products, quantities, delivery location, date, and delivery method.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/cd83b57f-2074-4167-be0b-87498be90fc8)


### Attributes

The `Delivery_Form` class is designed to manage the delivery process within the `hyacinthuslux` application. Here are the key attributes and their usage:

- **Delivery _delivery**:
  - **Purpose**: This private field is an instance of the `Delivery` class. It represents the current delivery being processed or edited in the form.
  - **Usage**: It is used to store details about the current delivery, including the client, products, quantities, delivery location, date, and delivery method. It is initialized when the form is created and populated with data as the user interacts with the form.

- **const string ConnectionString**:
  - **Purpose**: This constant string holds the connection string for the SQLite database used by the application.
  - **Usage**: It is used to establish a connection to the database whenever data needs to be read from or written to the database. This includes operations like adding, updating, or deleting deliveries.

- **int _editIndex**:
  - **Purpose**: This private integer field keeps track of the index of the delivery currently being edited.
  - **Usage**: It is used to determine whether the form is in "edit mode" or "create mode". If `_editIndex` is set to a valid index, the form will update the existing delivery at that index. If it is set to -1, the form will create a new delivery.

- **event EventHandler<DeliveryEventArgs> DeliverySaved**:
  - **Purpose**: This public event is triggered when a delivery is saved.
  - **Usage**: It is used to notify other parts of the application that a delivery has been saved. This event can be subscribed to by other forms or components to perform actions such as refreshing data or updating the user interface.

- **Dictionary<string, int> _remainingProductStocks**:
  - **Purpose**: This private dictionary holds the remaining stock quantities for each product.
  - **Usage**: It is used to keep track of how many units of each product are left in stock. When a delivery is processed, the quantities of the products in the delivery are subtracted from the remaining stock. This ensures that the stock levels are always accurate and up-to-date.


### Constructor

The `Delivery_Form` constructor initializes the form components, sets up the initial list of deliveries, and subscribes to the `DeliveryCreated` event.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/d5a3e7d1-5076-480f-96d9-49c4ffb316bd)

###### The Delivery_Form constructor in the hyacinthuslux application initializes the form for managing deliveries. It begins by calling InitializeComponent() to set up the form's visual components. Next, it creates a new Delivery object, initializing its DeliveryProducts property as an empty list of Product objects and its deliveryQuantities property as an empty list of integers. 
This prepares the Delivery object to store the necessary details for a new delivery. The constructor then copies the provided remainingProductStocks dictionary into a new dictionary, _remainingProductStocks, ensuring that the form has access to the current stock levels of products. Finally, it subscribes the ComboBoxCourierMethod_SelectedIndexChanged method to the SelectedIndexChanged event of the comboBoxCourierMethod control, allowing the form to respond appropriately whenever the selected courier method is changed by the user. This setup ensures the form is ready to manage delivery details and handle user interactions efficiently.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/efdd3d0e-be60-4396-8eed-e807a33364b9)

p.s Short: we needed the event so that we make sure that the total value of the delivery is automatically changed every time we select a new courier from the combobox


### Methods

1. **Delivery_Form_Load**: Loads the form, reads the delivery data from the database, and displays it.
2. **createDelivery**: Inserts a new delivery into the database.
3. **ReadDeliveries**: Reads all deliveries from the database and stores them in the `deliveries` list.
4. **DisplayDeliveries**: Displays the list of deliveries in the `ListView` control.
5. **deleteDelivery**: Deletes a delivery from the database by ID.
6. **ResetForm**: Resets the form fields to their default values.
7. **GetClients**: Fetches a list of clients to populate the client dropdown.
8. **GetProducts**: Fetches a list of products to populate the products dropdown.

### Event Handlers

1. **btnAdd_Click**: Adds a new delivery to the list and database.
2. **btnDelete_Click**: Deletes a selected delivery from the list and database.
3. **lvDeliveries_MouseDoubleClick**: Loads the selected delivery details into the form fields for editing.
4. **tbLocation_Validating**: Validates the location field to ensure it is not empty or whitespace.
5. **buttonOk_Click**: Processes and saves the delivery details when the "OK" button is clicked.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/b2eaaaea-7b40-4d5a-81e7-794db000ff63)


6. **ComboBoxCourierMethod_SelectedIndexChanged**: Updates the delivery method and recalculates the total value when the selected courier method changes.
### Subscription to DeliveryEventArgs

The `Delivery_Form` class subscribes to the `DeliveryCreated` event to handle the event when a new delivery is created.

#### Event Declaration

The `DeliveryCreated` event is declared using the `EventHandler<TEventArgs>` delegate, where `TEventArgs` is `DeliveryEventArgs`. This event is raised when a new delivery is created.

#### Event Subscription

In the `Delivery_Form` constructor, the `DeliveryCreated` event is subscribed to the `OnDeliveryCreated` method. This means that when the `DeliveryCreated` event is raised, the `OnDeliveryCreated` method will be called.

#### Event Raising

The `DeliveryCreated` event is raised in the `btnAdd_Click` method after a new delivery is added to the list and database. The `Invoke` method is used to raise the event, passing the current instance (`this`) as the sender and a new instance of `DeliveryEventArgs` containing the delivery as the event data.

#### Event Handling

The `OnDeliveryCreated` method handles the `DeliveryCreated` event. In this example, it displays a message box with the client's full name, indicating that a new delivery has been created.

By following this pattern, the `Delivery_Form` class ensures that whenever a new delivery is created, any subscribed event handlers are notified and can perform necessary actions, such as updating the UI or displaying messages to the user.


## MainForm

The `MainForm` class is designed to manage the main interface of the `hyacinthuslux` application. This form allows users to interact with client, product, and delivery data, and provides functionalities for managing and visualizing this data.


![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/5b9a05eb-ec5e-496a-ba2f-45e82491d971)


### Attributes

- **BindingList<Delivery> _deliveries**:
  - **Purpose**: A binding list that holds the delivery data.
  - **Usage**: It is used as the data source for the DataGridView to display deliveries.

- **Dictionary<string, int> _initialProductStocks**:
  - **Purpose**: Holds the initial stock quantities for each product.
  - **Usage**: It is populated when the form loads and is used to track the starting stock levels.

- **Dictionary<string, int> _remainingProductStocks**:
  - **Purpose**: Holds the remaining stock quantities for each product.
  - **Usage**: It is updated whenever deliveries are processed to ensure accurate stock tracking.

- **PropertyChangedEventHandler PropertyChanged**:
  - **Purpose**: An event that is triggered when a property value changes.
  - **Usage**: It is used to notify the UI of changes in the data, ensuring that the display is updated accordingly.

### Constructor

The `MainForm` constructor initializes the form components and sets up the initial lists for deliveries and product stocks.

### Methods

1. **MainForm_Load**: Loads the initial product stocks and sets up the DataGridView for displaying deliveries.
2. **LoadInitialProductStocks**: Fetches the initial product stock levels from the database.
3. **UpdateRemainingProductStocks**: Updates the remaining product stock levels based on the current deliveries.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/aec8433d-1451-462d-96a3-4e26c22bff72)


4. **addClientBtn_Click**: Opens the `Client_Form` to add a new client.
5. **btnAddProduct_Click**: Opens the `Product_Form` to add a new product.
6. **addDeliveryBtn_Click**: Opens the `Delivery_Form` to add a new delivery and subscribes to the `DeliverySaved` event.
7. **DeliveryForm_DeliverySaved**: Handles the `DeliverySaved` event by adding the new delivery to the list and updating the remaining product stocks.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/5d294281-a062-4cc0-a127-afe80ad0f0b7)

###### The addDeliveryBtn_Click and DeliveryForm_DeliverySaved methods work together to manage the addition of new deliveries within the MainForm. When the "Add Delivery" button is clicked, a new Delivery_Form is opened, and the DeliverySaved event is subscribed to handle the saving of the delivery. When a delivery is saved, the delivery data is added to the binding list, stock levels are updated, and the UI is refreshed to reflect the changes. This process ensures a smooth and efficient workflow for managing deliveries in the application.


8. **btnDeleteDelivery_Click**: Deletes the selected delivery from the list and updates the remaining product stocks.
9. **CouriersPieChart_Click**: Displays a pie chart showing the distribution of deliveries by courier method.
10. **CouriersBarChart_Click**: Displays a bar chart showing the distribution of deliveries by courier method.
11. **btnUserCtrl_Click**: Opens a user control chart to display the delivery data in a customizable format.
12. **OnPropertyChanged**: Notifies the UI of changes to the delivery data.

### Event Handlers

1. **addClientBtn_Click**: Opens the `Client_Form` to add a new client.
2. **btnAddProduct_Click**: Opens the `Product_Form` to add a new product.
3. **addDeliveryBtn_Click**: Opens the `Delivery_Form` to add a new delivery.
4. **DeliveryForm_DeliverySaved**: Handles the event when a delivery is saved.
5. **btnDeleteDelivery_Click**: Deletes a selected delivery from the list and database.
6. **CouriersPieChart_Click**: Displays a pie chart of courier distribution.
7. **CouriersBarChart_Click**: Displays a bar chart of courier distribution.
8. **btnUserCtrl_Click**: Opens a user control chart for deliveries.

## Class: UserControlChart

The `UserControlChart` class in the `hyacinthuslux` project is a form designed to display a chart representing the distribution of couriers used for deliveries. This form integrates a custom user control for drawing the chart and handles the presentation of data in a graphical format.

### Attributes

- **CourierDistributionChart courierDistributionChart**:
  - **Purpose**: This private field is an instance of the `CourierDistributionChart` user control. It represents the custom control used to draw and display the chart.
  - **Usage**: It is used to set up the chart control within the form, providing the data and refreshing the display to show the chart.

### Constructor

- **UserControlChart()**:
  - **Purpose**: Initializes the form components and sets up the `CourierDistributionChart` control.
  - **Usage**: The constructor is called when a new instance of the `UserControlChart` form is created. It prepares the form to display the chart by initializing components and configuring the chart control.

### Methods

1. **UserControlChart_Load**:
   - **Purpose**: Loads the form and initializes the chart control.
   - **Usage**: This method is called when the form is loaded. It sets the location and size of the `CourierDistributionChart` control and adds it to the form's controls collection.

2. **SetChart(string[] labels, int[] data)**:
   - **Purpose**: Sets the data for the chart and refreshes the display.
   - **Usage**: This method takes two arrays, one for labels and one for data, and passes them to the `CourierDistributionChart` control. It ensures that the chart is updated with the new data and displayed correctly.

### Integration with MainForm

The `UserControlChart` form is integrated into the `MainForm` of the `hyacinthuslux` application. The `btnUserCtrl_Click` event handler in `MainForm` creates and displays an instance of `UserControlChart`, passing the necessary data for the chart.

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/7acaa521-662d-4c8e-8909-d9f62c8243f2)

For button "Courier Bar Chart", the implementation for the bar chart is the same, but the implelentation is made in a class. We only create an object of the class "BarChartCouriers" and use the
contructor to pass a generic structure (a dictionary here) with the data of the couriers from the main form. Therefore, the key is the string representing the courier method (from the EnumCourier)
and the integer is the number of deliveries that method is used on.  
##### A particular aspect of this chart (although it a Bar Chart, as used in the user control), it is that for coloring the bars, I use an object of class Random :) 
![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/a7307f60-bbbd-476d-a3b9-b89604807b93)

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/11174388-d007-4e3b-b6d2-be163cba4ca6)

### So every time I click on "BarChartCouriers", a new color is shown for bars:

![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/cb50d16e-277f-4852-a3cb-6e20e41d62eb)


## Class: CouriersDistributionPieChart

The `CouriersDistributionPieChart` class in the `hyacinthuslux` project is designed to display a pie chart representing the distribution of couriers used for deliveries. This form takes a dictionary of courier distribution data and visualizes it using a pie chart.


![image](https://github.com/elngbr/hyacinthuslux/assets/142832941/8d2be33c-f391-463f-9f56-73e629d6c311)



### Attributes

- **Dictionary<EnumCourier.CourierEnum, int> courierDistribution**:
  - **Purpose**: This private field holds the courier distribution data passed to the form.
  - **Usage**: It is used to store the data needed to draw the pie chart, where the key represents the courier method and the value represents the number of deliveries made by that courier.

### Constructor

- **CouriersDistributionPieChart(Dictionary<EnumCourier.CourierEnum, int> courierDistribution)**:
  - **Purpose**: Initializes the form components and assigns the courier distribution data to the `courierDistribution` field.
  - **Usage**: This constructor is called when a new instance of the `CouriersDistributionPieChart` form is created, passing the courier distribution data needed for the pie chart.

### Methods

1. **OnPaint(PaintEventArgs e)**:
   - **Purpose**: Overrides the `OnPaint` method to draw the pie chart whenever the form needs to be repainted.
   - **Usage**: This method ensures that the pie chart is drawn whenever the form is rendered. It calls the `DrawPieChart` method with the graphics context and the courier distribution data.

2. **DrawPieChart(Graphics graphics, Dictionary<EnumCourier.CourierEnum, int> distribution)**:
   - **Purpose**: Draws the pie chart on the form using the provided graphics context and courier distribution data.
   - **Usage**: This method performs the actual drawing of the pie chart. It calculates the total number of deliveries, assigns colors to each courier, and draws the pie slices and legend.

### Integration with MainForm

The `CouriersDistributionPieChart` form is integrated into the `MainForm` of the `hyacinthuslux` application. The `CouriersPieChart_Click` event handler in `MainForm` creates and displays an instance of `CouriersDistributionPieChart`, passing the necessary courier distribution data.












