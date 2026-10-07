# <a id="Divine_Helpers_MessageBox"></a> Class MessageBox

Namespace: [Divine.Helpers](Divine.Helpers.md)  
Assembly: Divine.Common.dll  

```csharp
public static class MessageBox
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[MessageBox](Divine.Helpers.MessageBox.md)

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_)

## Methods

### <a id="Divine_Helpers_MessageBox_Show_System_String_Divine_Helpers_MessageBox_Icon_"></a> Show\(string, Icon\)

```csharp
public static MessageBox.Result Show(string text, MessageBox.Icon icon = Icon.None)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`icon` [MessageBox](Divine.Helpers.MessageBox.md).[Icon](Divine.Helpers.MessageBox.Icon.md)

#### Returns

 [MessageBox](Divine.Helpers.MessageBox.md).[Result](Divine.Helpers.MessageBox.Result.md)

### <a id="Divine_Helpers_MessageBox_Show_System_String_Divine_Helpers_MessageBox_Buttons_Divine_Helpers_MessageBox_Icon_"></a> Show\(string, Buttons, Icon\)

```csharp
public static MessageBox.Result Show(string text, MessageBox.Buttons buttons, MessageBox.Icon icon = Icon.None)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`buttons` [MessageBox](Divine.Helpers.MessageBox.md).[Buttons](Divine.Helpers.MessageBox.Buttons.md)

`icon` [MessageBox](Divine.Helpers.MessageBox.md).[Icon](Divine.Helpers.MessageBox.Icon.md)

#### Returns

 [MessageBox](Divine.Helpers.MessageBox.md).[Result](Divine.Helpers.MessageBox.Result.md)

### <a id="Divine_Helpers_MessageBox_Show_System_String_System_String_Divine_Helpers_MessageBox_Icon_"></a> Show\(string, string, Icon\)

```csharp
public static MessageBox.Result Show(string text, string title, MessageBox.Icon icon = Icon.None)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

`icon` [MessageBox](Divine.Helpers.MessageBox.md).[Icon](Divine.Helpers.MessageBox.Icon.md)

#### Returns

 [MessageBox](Divine.Helpers.MessageBox.md).[Result](Divine.Helpers.MessageBox.Result.md)

### <a id="Divine_Helpers_MessageBox_Show_System_String_System_String_Divine_Helpers_MessageBox_Buttons_Divine_Helpers_MessageBox_Icon_"></a> Show\(string, string, Buttons, Icon\)

```csharp
public static MessageBox.Result Show(string text, string title, MessageBox.Buttons buttons, MessageBox.Icon icon = Icon.None)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

`buttons` [MessageBox](Divine.Helpers.MessageBox.md).[Buttons](Divine.Helpers.MessageBox.Buttons.md)

`icon` [MessageBox](Divine.Helpers.MessageBox.md).[Icon](Divine.Helpers.MessageBox.Icon.md)

#### Returns

 [MessageBox](Divine.Helpers.MessageBox.md).[Result](Divine.Helpers.MessageBox.Result.md)

### <a id="Divine_Helpers_MessageBox_ShowError_System_String_"></a> ShowError\(string\)

```csharp
public static void ShowError(string text)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Helpers_MessageBox_ShowError_System_String_System_String_"></a> ShowError\(string, string\)

```csharp
public static void ShowError(string text, string title)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

