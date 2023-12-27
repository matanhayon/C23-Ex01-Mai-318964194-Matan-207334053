
Facebook Desktop Application
Overview
This GitHub project is a Facebook desktop application developed by Mai Chaouat and Matan Hayon. The application incorporates various design patterns to enhance functionality and maintainability.

Implemented Features
1. Sorting and Downloading Albums
How to Use:
Users can fetch albums to display them sorted by the newest.
Users can choose categories for sorting, such as very old, size (small to large), and size (large to small).
Users have the option to download an album to a folder on their computer.
Realization:
Sort Albums:
Implementation in FormMain::SortAlbums, utilizing AlbumsManager::SortAlbums to sort albums based on the user's chosen option.
Album Download:
Implementation in FormMain::downloadAlbum to download the desired album chosen by the user.
2. Post Statistics
Total Posts Graph:
Displays the total number of user posts in annual segmentation since the beginning of using Facebook.
Implementation in FormMain::calculatePostsCountByMonthChart.
Graph Posts by Month:
Shows the amount of posts for a requested year in monthly segmentation.
Displays the total amount of posts that the user has uploaded in this year.
Realization:
Segmentation of All Posts:
Utilizes FormMain::CalculateTotalPostsChart, which employs PostsManager::CalculateTotalPostsByYear to calculate the total number of posts.
Updates the chart in FormMain::UpdateTotalPostsChart.
Segmentation by Years:
Uses FormMain::CalculatePostCountByMonthChart, which utilizes PostsManager::CalculatePostCountByMonth to calculate the amount of posts per month.
Updates the chart in FormMain::UpdatePostCountByMonthChart.
Design Patterns
1. Singleton Pattern
Reason for Choosing:
Ensures a single, thread-safe instance for connecting to Facebook.
Prevents multiple users from connecting simultaneously.
Method of Realization:
Implemented in the FacebookManager class with a private constructor and a public static method Initialize.
The public static property Instance allows thread-safe access to the object.
2. Builder Pattern
Reason for Choosing:
Allows users to define the objects they want to see in the system.
Reduces server load and avoids creating unnecessary objects.
Method of Realization:
Utilized in the creation of forms based on user preferences.
Involves FakeBookLoginForm, FormComposer, and FormBuilder classes.
3. Static Factory Pattern
Reason for Choosing:
Enables the creation of polymorphic objects using a static class (StaticFormFactory).
Prevents code duplication and simplifies object creation.
Method of Realization:
StaticFormFactory produces objects based on the type of product (albums, posts, or pages).
AbstractForm, AlbumsFormProduct, PagesFormProduct, and PostsFormProduct classes.
4. Data Binning and Threads
Implemented with every access to the Facebook server to optimize running time and receive data in methods across different departments.
How to Use
Clone the repository.
Configure software: Choose debug and x64 configuration.
Start the application.

