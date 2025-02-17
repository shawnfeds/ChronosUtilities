# ChronosUtilities

**ChronosUtilities** is a .NET library for handling date and time operations, including date calculations, time zone conversions, and business day calculations.

## Features

- **Date Calculations**: Add or subtract days, weeks, months, or years from a given date.
- **Time Zone Conversions**: Convert dates and times between different time zones.
- **Business Day Calculator**: Calculate the number of business days between two dates.

## Installation

Install the NuGet package using the following command:

```sh
dotnet add package ChronosUtilities
```

## Usage

### Date Calculations
```sh
using ChronosUtilities.Calculations;

DateTime date = new DateTime(2023, 1, 1);
DateTime newDate = DateCalculations.AddDays(date, 5);
Console.WriteLine(newDate); // Output: 2023-01-06
```
### Time Zone Conversions
```sh
using ChronosUtilities.TimeZoneConversions;

DateTime date = new DateTime(2023, 1, 1, 12, 0, 0);
string timeZoneId = "Pacific Standard Time";
DateTime convertedDate = TimeZoneConverter.ConvertToTimeZone(date, timeZoneId);
Console.WriteLine(convertedDate); // Output: Converted date and time in Pacific Standard Time
```
### Business Day Calculator
```sh
using ChronosUtilities.BusinessDayCalculator;

DateTime startDate = new DateTime(2023, 1, 1);
DateTime endDate = new DateTime(2023, 1, 10);
int businessDays = BusinessDayCalculator.CalculateBusinessDays(startDate, endDate);
Console.WriteLine(businessDays); // Output: 7
```
License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
For any questions or suggestions, please contact [Shawn Fernandes] at [shawnfeds88@outlook.com].
