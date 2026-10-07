# <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu"></a> Class CSVCMsg\_Menu

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_Menu : IMessage<CSVCMsg_Menu>, IEquatable<CSVCMsg_Menu>, IDeepCloneable<CSVCMsg_Menu>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_Menu](Divine.Protobufs.Dota2.CSVCMsg\_Menu.md)

#### Implements

IMessage<CSVCMsg\_Menu\>, 
[IEquatable<CSVCMsg\_Menu\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_Menu\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CSVCMsg\_Menu\>\(CSVCMsg\_Menu, params CSVCMsg\_Menu\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu__ctor"></a> CSVCMsg\_Menu\(\)

```csharp
public CSVCMsg_Menu()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu__ctor_Divine_Protobufs_Dota2_CSVCMsg_Menu_"></a> CSVCMsg\_Menu\(CSVCMsg\_Menu\)

```csharp
public CSVCMsg_Menu(CSVCMsg_Menu other)
```

#### Parameters

`other` [CSVCMsg\_Menu](Divine.Protobufs.Dota2.CSVCMsg\_Menu.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_DialogTypeFieldNumber"></a> DialogTypeFieldNumber

```csharp
public const int DialogTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_MenuKeyValuesFieldNumber"></a> MenuKeyValuesFieldNumber

```csharp
public const int MenuKeyValuesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_DialogType"></a> DialogType

```csharp
public int DialogType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_HasDialogType"></a> HasDialogType

```csharp
public bool HasDialogType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_HasMenuKeyValues"></a> HasMenuKeyValues

```csharp
public bool HasMenuKeyValues { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_MenuKeyValues"></a> MenuKeyValues

```csharp
public ByteString MenuKeyValues { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_Menu> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_Menu](Divine.Protobufs.Dota2.CSVCMsg\_Menu.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_ClearDialogType"></a> ClearDialogType\(\)

```csharp
public void ClearDialogType()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_ClearMenuKeyValues"></a> ClearMenuKeyValues\(\)

```csharp
public void ClearMenuKeyValues()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_Menu Clone()
```

#### Returns

 [CSVCMsg\_Menu](Divine.Protobufs.Dota2.CSVCMsg\_Menu.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_Equals_Divine_Protobufs_Dota2_CSVCMsg_Menu_"></a> Equals\(CSVCMsg\_Menu\)

```csharp
public bool Equals(CSVCMsg_Menu other)
```

#### Parameters

`other` [CSVCMsg\_Menu](Divine.Protobufs.Dota2.CSVCMsg\_Menu.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_Menu_"></a> MergeFrom\(CSVCMsg\_Menu\)

```csharp
public void MergeFrom(CSVCMsg_Menu other)
```

#### Parameters

`other` [CSVCMsg\_Menu](Divine.Protobufs.Dota2.CSVCMsg\_Menu.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_Menu_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

