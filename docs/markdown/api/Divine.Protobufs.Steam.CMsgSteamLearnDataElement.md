# <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement"></a> Class CMsgSteamLearnDataElement

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnDataElement : IMessage<CMsgSteamLearnDataElement>, IEquatable<CMsgSteamLearnDataElement>, IDeepCloneable<CMsgSteamLearnDataElement>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnDataElement](Divine.Protobufs.Steam.CMsgSteamLearnDataElement.md)

#### Implements

IMessage<CMsgSteamLearnDataElement\>, 
[IEquatable<CMsgSteamLearnDataElement\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnDataElement\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnDataElement\>\(CMsgSteamLearnDataElement, params CMsgSteamLearnDataElement\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement__ctor"></a> CMsgSteamLearnDataElement\(\)

```csharp
public CMsgSteamLearnDataElement()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement__ctor_Divine_Protobufs_Steam_CMsgSteamLearnDataElement_"></a> CMsgSteamLearnDataElement\(CMsgSteamLearnDataElement\)

```csharp
public CMsgSteamLearnDataElement(CMsgSteamLearnDataElement other)
```

#### Parameters

`other` [CMsgSteamLearnDataElement](Divine.Protobufs.Steam.CMsgSteamLearnDataElement.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataBoolsFieldNumber"></a> DataBoolsFieldNumber

```csharp
public const int DataBoolsFieldNumber = 22
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataFloatsFieldNumber"></a> DataFloatsFieldNumber

```csharp
public const int DataFloatsFieldNumber = 21
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataInt32SFieldNumber"></a> DataInt32SFieldNumber

```csharp
public const int DataInt32SFieldNumber = 20
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataObjectsFieldNumber"></a> DataObjectsFieldNumber

```csharp
public const int DataObjectsFieldNumber = 24
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataStringsFieldNumber"></a> DataStringsFieldNumber

```csharp
public const int DataStringsFieldNumber = 23
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataBools"></a> DataBools

```csharp
public RepeatedField<bool> DataBools { get; }
```

#### Property Value

 RepeatedField<[bool](https://learn.microsoft.com/dotnet/api/system.boolean)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataFloats"></a> DataFloats

```csharp
public RepeatedField<float> DataFloats { get; }
```

#### Property Value

 RepeatedField<[float](https://learn.microsoft.com/dotnet/api/system.single)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataInt32S"></a> DataInt32S

```csharp
public RepeatedField<int> DataInt32S { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataObjects"></a> DataObjects

```csharp
public RepeatedField<CMsgSteamLearnDataObject> DataObjects { get; }
```

#### Property Value

 RepeatedField<[CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_DataStrings"></a> DataStrings

```csharp
public RepeatedField<string> DataStrings { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnDataElement> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnDataElement](Divine.Protobufs.Steam.CMsgSteamLearnDataElement.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnDataElement Clone()
```

#### Returns

 [CMsgSteamLearnDataElement](Divine.Protobufs.Steam.CMsgSteamLearnDataElement.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_Equals_Divine_Protobufs_Steam_CMsgSteamLearnDataElement_"></a> Equals\(CMsgSteamLearnDataElement\)

```csharp
public bool Equals(CMsgSteamLearnDataElement other)
```

#### Parameters

`other` [CMsgSteamLearnDataElement](Divine.Protobufs.Steam.CMsgSteamLearnDataElement.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnDataElement_"></a> MergeFrom\(CMsgSteamLearnDataElement\)

```csharp
public void MergeFrom(CMsgSteamLearnDataElement other)
```

#### Parameters

`other` [CMsgSteamLearnDataElement](Divine.Protobufs.Steam.CMsgSteamLearnDataElement.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnDataElement_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

