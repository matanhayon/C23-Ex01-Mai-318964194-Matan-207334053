Facebook Desktop Application
============================

Overview
--------

This GitHub project is a Facebook desktop application developed by Mai Chaouat and Matan Hayon. The application incorporates various design patterns to enhance functionality and maintainability.

Implemented Features
--------------------

### 1\. Sorting and Downloading Albums

**How to Use:**

*   Users can fetch albums to display them sorted by the newest.
*   Users can choose categories for sorting, such as very old, size (small to large), and size (large to small).
*   Users have the option to download an album to a folder on their computer.

**Realization:**

*   **Sort Albums:**
    *   Implementation in `FormMain::SortAlbums`, utilizing `AlbumsManager::SortAlbums` to sort albums based on the user's chosen option.
*   **Album Download:**
    *   Implementation in `FormMain::downloadAlbum` to download the desired album chosen by the user.

### 2\. Post Statistics

**Total Posts Graph:**

*   Displays the total number of user posts in annual segmentation since the beginning of using Facebook.
*   Implementation in `FormMain::calculatePostsCountByMonthChart`.

**Graph Posts by Month:**

*   Shows the amount of posts for a requested year in monthly segmentation.
*   Displays the total amount of posts that the user has uploaded in this year.

**Realization:**

*   **Segmentation of All Posts:**
    *   Utilizes `FormMain::CalculateTotalPostsChart`, which employs `PostsManager::CalculateTotalPostsByYear` to calculate the total number of posts.
    *   Updates the chart in `FormMain::UpdateTotalPostsChart`.
*   **Segmentation by Years:**
    *   Uses `FormMain::CalculatePostCountByMonthChart`, which utilizes `PostsManager::CalculatePostCountByMonth` to calculate the amount of posts per month.
    *   Updates the chart in `FormMain::UpdatePostCountByMonthChart`.

Design Patterns
---------------

### 1\. Singleton Pattern

**Reason for Choosing:**

*   Ensures a single, thread-safe instance for connecting to Facebook.
*   Prevents multiple users from connecting simultaneously.

**Method of Realization:**

*   Implemented in the `FacebookManager` class with a private constructor and a public static method `Initialize`.
*   The public static property `Instance` allows thread-safe access to the object.

### 2\. Builder Pattern

**Reason for Choosing:**

*   Allows users to define the objects they want to see in the system.
*   Reduces server load and avoids creating unnecessary objects.

**Method of Realization:**

*   Utilized in the creation of forms based on user preferences.
*   Involves `FakeBookLoginForm`, `FormComposer`, and `FormBuilder` classes.

### 3\. Static Factory Pattern

**Reason for Choosing:**

*   Enables the creation of polymorphic objects using a static class (`StaticFormFactory`).
*   Prevents code duplication and simplifies object creation.

**Method of Realization:**

*   `StaticFormFactory` produces objects based on the type of product (albums, posts, or pages).
*   `AbstractForm`, `AlbumsFormProduct`, `PagesFormProduct`, and `PostsFormProduct` classes.

### 4\. Command Pattern

**Reason for Choosing:**

*   Enhances extensibility by allowing easy addition of new commands (form types) without changing existing code.
*   Provides flexibility to change, replace, or extend individual commands independently.

**Method of Realization:**

*   Implemented in the creation of various forms (albums, pages, and posts) from `StaticFormFactory`.
*   Involves `AbstractForm`, concrete command classes (`AlbumsFormCommand`, `PagesFormCommand`, `PostsFormCommand`), and a client class (`DynamicFormFactory`).

### 5\. Strategy Pattern

**Reason for Choosing:**

*   Facilitates future changes in sorting options for albums.
*   Enhances maintainability by separating sorting strategies into different departments.

**Method of Realization:**

*   `IAlbumSortingStrategy` defines the `SortAlbums` method, and concrete strategy classes (`LargestAlbumSortingStrategy`, `SmallestAlbumSortingStrategy`, `NewestAlbumSortingStrategy`, `OldestAlbumSortingStrategy`) implement it.
*   `AlbumsManager` holds an instance of `IAlbumSortingStrategy` and invokes `AlbumsManager::SortAlbums` based on the user's choice.

### 6\. Observer Pattern

**Reason for Choosing:**

*   Allows data to be updated every 10 minutes for real-time updates in the application.
*   Provides separation and flexibility in handling data updates.

**Advantages:**

1.  Separation (encapsulation) of classes responsible for updating and displaying data.
2.  Flexibility in adding or removing observers without changing the code.
3.  Real-time updates for regularly refreshed data.

**Method of Realization:**

*   Used for updating data every 10 minutes in the Facebook application.
*   Enables easy addition or removal of observers without changing the central logic responsible for updating data.

### 7\. Data Binning and Threads

*   Implemented with every access to the Facebook server to optimize running time and receive data in methods across different departments.

How to Use
----------

1.  Clone the repository.
2.  Configure software: Choose debug and x64 configuration.
3.  Start the applicatio
