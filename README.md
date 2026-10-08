# Module 7 JSON Student Records

## Purpose
A C# Windows Form application developed to enter, validate, display, serialize, and deserialize records using JSON.

## Usage
* **Add a student:** Input valid student data into the text and numeric fields, then press the "Add Student" button to add a record to the students list.
* **Save records:** Click the "Save to JSON" button to serialize and save the student list to a JSON file.
* **Load records:** Click the "Load from JSON" button to deserialize and load the student list from the JSON file.
* **Clear Display:** Click the "Clear Display" button to empty both the DataGridView and the in-memory students list without modifying the saved JSON file.

## File Storage
The `students.json` file is saved in the application's startup path.

## Known Limitations
* Individual records cannot be edited or deleted once added to the list.
* Loading a JSON file replaces the current in-memory students list rather than appending to it.
