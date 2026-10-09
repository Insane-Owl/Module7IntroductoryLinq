# Module 7 Introductory Linq

## Purpose
A C# Windows Form application that uses LINQ to filter, query, and summarize a set of student records.

## Data Management
Student records are stored in a `List<Student>` which is populated dynamically on program startup. These records are loaded from a `students.json` file, which was generated using [Module 8 JSON Student Records](https://github.com/Insane-Owl/Module7JsonStudentRecords).

## Usage
Use the interface controls to execute the following operations:
* **Show All:** Displays the original, unfiltered collection.
* **Filter by Program:** Select an academic program from the dropdown (which is automatically populated on load) and click the button to view enrolled students.
* **Filter by GPA:** Enter a numeric value in the `Minimum GPA:` box, and press this button to view all students with a GPA equal to or greater.
* **Search for Student:** Enter an exact student ID, or a partial student name (first or last), in the query box and click this button to find specific records.
* **Sort by Last Name:** Arrange the table alphabetically by last name.
* **Sort by GPA:** Arrange the table numerically by highest GPA.
* **Display Summary:** Calculate and display general dataset metrics.
* **Combined Query:** Select a program and a minimum GPA, then click this button to filter by both conditions at the same time while sorting the results.

## LINQ Operators Utilized
The application uses the following LINQ methods:
*   `Where()`
*   `OrderBy()` and `OrderByDescending()`
*   `ThenBy()`
*   `FirstOrDefault()`
*   `Count()`
*   `Average()`
*   `Max()`
*   `Min()`

## Summary Calculations
Summary information is generated using LINQ methods on the main student list to calculate the total student count, average GPA, highest/lowest GPAs, and the count of students with a 3.0 GPA or higher. The application verifies that the collection is not empty before running these calculations to errors.

## Known Limitations
*   Searches are currently limited to ID, First Name, and Last Name fields.
*   Sorting operations only affect the DataGridView display and do not permanently reorder the underlying `students.json` file or in-memory `students` list.
