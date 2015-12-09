# MagicBox
The Magic Box is a full featured library to provide you a big set of customized:
* Behaviors; 
* Controls; 
* Converters:
  * **BooleanToBrushConverter:** According of a boolean value it is retorned a different SolidColorBrush object, *works with __TwoWay__ binding*.
  * **DateTimeToTimeSpanConverter:** Converts a DateTime object to TimeSpan isntance, in the converter using the TimeSpan.TimeOfDay, but, in the ConvertBack, instead that it is retorned the current day added the TimeSpan value that is passed on method's argument, *works with __TwoWay__ binding*.
  * **StringToVisibilityConverter:** If the string value is not null, empty or white spaced the Visibility object retorned is Visible, otherwise it is Collapsed.
  * **VisibilityInverterConverter:** According of a Visibility value it is retorned the inversed of that value, e.g. Visibility.Visible <=> Visibility.Collapsed, *__NOT__ works with __TwoWay__ binding*.

* Helpers:
  * **UiHelper:** Contains static method to be used to help you working on or with UI thread.

* Services; 
* And, more to facilitate the Windows Development. 

Also can contains some solutions for Xamarin.
