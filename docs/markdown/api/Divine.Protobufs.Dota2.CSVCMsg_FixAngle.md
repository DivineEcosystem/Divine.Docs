# <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle"></a> Class CSVCMsg\_FixAngle

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_FixAngle : IMessage<CSVCMsg_FixAngle>, IEquatable<CSVCMsg_FixAngle>, IDeepCloneable<CSVCMsg_FixAngle>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_FixAngle](Divine.Protobufs.Dota2.CSVCMsg\_FixAngle.md)

#### Implements

IMessage<CSVCMsg\_FixAngle\>, 
[IEquatable<CSVCMsg\_FixAngle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_FixAngle\>, 
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
[EnumerableExtensions.In<CSVCMsg\_FixAngle\>\(CSVCMsg\_FixAngle, params CSVCMsg\_FixAngle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle__ctor"></a> CSVCMsg\_FixAngle\(\)

```csharp
public CSVCMsg_FixAngle()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle__ctor_Divine_Protobufs_Dota2_CSVCMsg_FixAngle_"></a> CSVCMsg\_FixAngle\(CSVCMsg\_FixAngle\)

```csharp
public CSVCMsg_FixAngle(CSVCMsg_FixAngle other)
```

#### Parameters

`other` [CSVCMsg\_FixAngle](Divine.Protobufs.Dota2.CSVCMsg\_FixAngle.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_AngleFieldNumber"></a> AngleFieldNumber

```csharp
public const int AngleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_RelativeFieldNumber"></a> RelativeFieldNumber

```csharp
public const int RelativeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_Angle"></a> Angle

```csharp
public CMsgQAngle Angle { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_HasRelative"></a> HasRelative

```csharp
public bool HasRelative { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_FixAngle> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_FixAngle](Divine.Protobufs.Dota2.CSVCMsg\_FixAngle.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_Relative"></a> Relative

```csharp
public bool Relative { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_ClearRelative"></a> ClearRelative\(\)

```csharp
public void ClearRelative()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_FixAngle Clone()
```

#### Returns

 [CSVCMsg\_FixAngle](Divine.Protobufs.Dota2.CSVCMsg\_FixAngle.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_Equals_Divine_Protobufs_Dota2_CSVCMsg_FixAngle_"></a> Equals\(CSVCMsg\_FixAngle\)

```csharp
public bool Equals(CSVCMsg_FixAngle other)
```

#### Parameters

`other` [CSVCMsg\_FixAngle](Divine.Protobufs.Dota2.CSVCMsg\_FixAngle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_FixAngle_"></a> MergeFrom\(CSVCMsg\_FixAngle\)

```csharp
public void MergeFrom(CSVCMsg_FixAngle other)
```

#### Parameters

`other` [CSVCMsg\_FixAngle](Divine.Protobufs.Dota2.CSVCMsg\_FixAngle.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_FixAngle_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

