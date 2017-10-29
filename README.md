# Assignment #8: Week 42

## Software Engineering

### Exercise 1

## C&#35;

Fork this repository and implement the code required for the assignments below.

### Slot Car Tournament part cinq

![](images/race-party-slot-party.jpg "Slot Cars")

Implement and test master-detail UWP app.

The app should display a list/grid of tracks on the main page.
Tapping a track should go to a track page with more details.
A back button should be implemented to allow the user to go back and forth between master and detail views.

Tracks should be loaded from the `TrackRepository`.

Implementation should use an IoC container to load the view model and dependencies.

## Note on unit testing UWP apps

Currently there is a known bug with the Test Explorer and UWP apps targeting the *Windows 10 Fall Creators Update*.
The bug is expected to be fixed with the release of Visual Studio 2017 Version 15.5.

Running tests in the current setup will be demonstrated in the next lecture.
