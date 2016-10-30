# MoreDotNet

## Status

[![Build status](https://ci.appveyor.com/api/projects/status/41edqunjstgy8vv5?svg=true)](https://ci.appveyor.com/project/Teodor92/moredotnet)

[![NuGet version](https://badge.fury.io/nu/MoreDotNet.svg)](https://badge.fury.io/nu/MoreDotNet)


## Summary

This project is a collection of handy extension methods for the .NET Framework. The functionality of this package can be separated in the following groups:

#### Extension methods for common .NET types:
---

* ICollection:

```cs 
AddRange() 
```

* IDictionary:

```cs 
GetOrDefault()
GetKeyIgnoringCase()
```

* IEnumerable:
```cs 
ForEach()
EmptyIfNull()
Shuffle()
ToString()
IsNullOrEmpty()
```

* IList:
```cs 
BinarySearch()
ToDataTable()
InsertionSort()
InsertWhere()
RemoveAll()
```

* Bitmap:
```cs 
ToGrayScale()
```

* bool:
```cs 
WhenTrue()
WhenFalse()
```

* ByteArray:
```cs 
GetString()
```

* Color:
```cs 
ToHexString()
ToRgbString()
ToGray()
ToReadableForegroundColor()
```

* IConvertible:
```cs 
To()
ToOrDefault()
ToOrOther()
ToOrNull()
```

* IDataRecord:
```cs 
GetNullable()
```

* DateTime:
```cs 
FirstDayOfMonth()
LastDayOfMonth()
NextDate()
Midnight()
Noon()
WithTime()
IsFuture()
IsPast()
IsWorkDay()
IsWeekend()
NextWorkday()
```

* Enum:
```cs 
GetDisplayName()
GetDescription()
```

* Generics
```cs 
IsBetween()
GetMemberName()
```

* int:
```cs 
RangeTo()
```

* object:
```cs 
Is()
IsNot()
As()
ToDictionary()
```

* OperatingSystem:
```cs 
IsWinXpOrHigher()
IsWinVistaOrHigher()
IsWin7OrHigher()
IsWin8OrHigher()
```

* Random:
```cs 
OneOf()
NextBool()
NextChar()
NextDateTime()
NextDouble()
NextString()
NextTimeSpan()
```

* Stream:
```cs 
ToByteArray()
ToStream()
```

* string:
```cs 
ToTitleCase()
CaseToWords()
Capitalize()
IsLike()
ToMaximumLengthString()
NthIndexOf()
RemoveLastCharacter()
RemoveLast()
RemoveFirstCharacter()
RemoveFirst()
```

* Type:
```cs 
IsNullable()
GetCoreType()
```

* Xml:
```cs 
XmlSerialize()
XmlDeserialize()
```

* RomanNumeral:
```cs 
IsValidRomanNumeral()
ParseRomanNumeral()
ToRomanNumeralString()
```

#### Static helpers:
---

* Directory:
```cs 
CreateTempDirectory()
SafeDeleteDirectory()
```

* File:
```cs 
SaveStringToTempFile()
SaveByteArrayToTempFile()
```

#### Wrappers for transforming common static methods to instance methods:
---

Example:
```cs
string.IsNullOrWhiteSpace(testStringVar)
```
Is transformed to:
```cs
testStringVar.IsNullOrWhiteSpace()
```

## Installation

NOTE: The package is still under development and some bugs may exist!

You can install the library using NuGet into your project:

```
Install-Package MoreDotNet
```

## License

Code by Teodor Kurtev. Copyright 2016 Teodor Kurtev.

This package has MIT license. Refer to the LICENSE for detailed information.

## License

Code by Teodor Kurtev. Copyright 2016 Teodor Kurtev.

This package has MIT license. Refer to the [LICENSE](https://github.com/Teodor92/MoreDotNet/blob/master/LICENSE) for detailed information.

## Any questions, comments or additions?

If you have a feature request or bug report, leave an issue on the [issues page](https://github.com/Teodor92/MoreDotNet/issues) or send a [pull request](https://github.com/Teodor92/MoreDotNet/pulls). For general questions and comments, use the [StackOverflow](http://stackoverflow.com/) forum.