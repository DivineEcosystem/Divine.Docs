# <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement"></a> Class CMsgSteamLearnDataSourceDescElement

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnDataSourceDescElement : IMessage<CMsgSteamLearnDataSourceDescElement>, IEquatable<CMsgSteamLearnDataSourceDescElement>, IDeepCloneable<CMsgSteamLearnDataSourceDescElement>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnDataSourceDescElement](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescElement.md)

#### Implements

IMessage<CMsgSteamLearnDataSourceDescElement\>, 
[IEquatable<CMsgSteamLearnDataSourceDescElement\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnDataSourceDescElement\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnDataSourceDescElement\>\(CMsgSteamLearnDataSourceDescElement, params CMsgSteamLearnDataSourceDescElement\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement__ctor"></a> CMsgSteamLearnDataSourceDescElement\(\)

```csharp
public CMsgSteamLearnDataSourceDescElement()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement__ctor_Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_"></a> CMsgSteamLearnDataSourceDescElement\(CMsgSteamLearnDataSourceDescElement\)

```csharp
public CMsgSteamLearnDataSourceDescElement(CMsgSteamLearnDataSourceDescElement other)
```

#### Parameters

`other` [CMsgSteamLearnDataSourceDescElement](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescElement.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_DataTypeFieldNumber"></a> DataTypeFieldNumber

```csharp
public const int DataTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_ObjectFieldNumber"></a> ObjectFieldNumber

```csharp
public const int ObjectFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Count"></a> Count

```csharp
public uint Count { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_DataType"></a> DataType

```csharp
public ESteamLearnDataType DataType { get; set; }
```

#### Property Value

 [ESteamLearnDataType](Divine.Protobufs.Steam.ESteamLearnDataType.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_HasDataType"></a> HasDataType

```csharp
public bool HasDataType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Object"></a> Object

```csharp
public CMsgSteamLearnDataSourceDescObject Object { get; set; }
```

#### Property Value

 [CMsgSteamLearnDataSourceDescObject](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescObject.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnDataSourceDescElement> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnDataSourceDescElement](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescElement.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_ClearDataType"></a> ClearDataType\(\)

```csharp
public void ClearDataType()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnDataSourceDescElement Clone()
```

#### Returns

 [CMsgSteamLearnDataSourceDescElement](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescElement.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_Equals_Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_"></a> Equals\(CMsgSteamLearnDataSourceDescElement\)

```csharp
public bool Equals(CMsgSteamLearnDataSourceDescElement other)
```

#### Parameters

`other` [CMsgSteamLearnDataSourceDescElement](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescElement.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_"></a> MergeFrom\(CMsgSteamLearnDataSourceDescElement\)

```csharp
public void MergeFrom(CMsgSteamLearnDataSourceDescElement other)
```

#### Parameters

`other` [CMsgSteamLearnDataSourceDescElement](Divine.Protobufs.Steam.CMsgSteamLearnDataSourceDescElement.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataSourceDescElement_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

