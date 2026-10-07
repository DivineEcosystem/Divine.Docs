# <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle"></a> Class CEntityMessageFixAngle

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CEntityMessageFixAngle : IMessage<CEntityMessageFixAngle>, IEquatable<CEntityMessageFixAngle>, IDeepCloneable<CEntityMessageFixAngle>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CEntityMessageFixAngle](Divine.Protobufs.Dota2.CEntityMessageFixAngle.md)

#### Implements

IMessage<CEntityMessageFixAngle\>, 
[IEquatable<CEntityMessageFixAngle\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CEntityMessageFixAngle\>, 
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
[EnumerableExtensions.In<CEntityMessageFixAngle\>\(CEntityMessageFixAngle, params CEntityMessageFixAngle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle__ctor"></a> CEntityMessageFixAngle\(\)

```csharp
public CEntityMessageFixAngle()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle__ctor_Divine_Protobufs_Dota2_CEntityMessageFixAngle_"></a> CEntityMessageFixAngle\(CEntityMessageFixAngle\)

```csharp
public CEntityMessageFixAngle(CEntityMessageFixAngle other)
```

#### Parameters

`other` [CEntityMessageFixAngle](Divine.Protobufs.Dota2.CEntityMessageFixAngle.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_AngleFieldNumber"></a> AngleFieldNumber

```csharp
public const int AngleFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_EntityMsgFieldNumber"></a> EntityMsgFieldNumber

```csharp
public const int EntityMsgFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_RelativeFieldNumber"></a> RelativeFieldNumber

```csharp
public const int RelativeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_Angle"></a> Angle

```csharp
public CMsgQAngle Angle { get; set; }
```

#### Property Value

 [CMsgQAngle](Divine.Protobufs.Dota2.CMsgQAngle.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_EntityMsg"></a> EntityMsg

```csharp
public CEntityMsg EntityMsg { get; set; }
```

#### Property Value

 [CEntityMsg](Divine.Protobufs.Dota2.CEntityMsg.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_HasRelative"></a> HasRelative

```csharp
public bool HasRelative { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_Parser"></a> Parser

```csharp
public static MessageParser<CEntityMessageFixAngle> Parser { get; }
```

#### Property Value

 MessageParser<[CEntityMessageFixAngle](Divine.Protobufs.Dota2.CEntityMessageFixAngle.md)\>

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_Relative"></a> Relative

```csharp
public bool Relative { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_ClearRelative"></a> ClearRelative\(\)

```csharp
public void ClearRelative()
```

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_Clone"></a> Clone\(\)

```csharp
public CEntityMessageFixAngle Clone()
```

#### Returns

 [CEntityMessageFixAngle](Divine.Protobufs.Dota2.CEntityMessageFixAngle.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_Equals_Divine_Protobufs_Dota2_CEntityMessageFixAngle_"></a> Equals\(CEntityMessageFixAngle\)

```csharp
public bool Equals(CEntityMessageFixAngle other)
```

#### Parameters

`other` [CEntityMessageFixAngle](Divine.Protobufs.Dota2.CEntityMessageFixAngle.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_MergeFrom_Divine_Protobufs_Dota2_CEntityMessageFixAngle_"></a> MergeFrom\(CEntityMessageFixAngle\)

```csharp
public void MergeFrom(CEntityMessageFixAngle other)
```

#### Parameters

`other` [CEntityMessageFixAngle](Divine.Protobufs.Dota2.CEntityMessageFixAngle.md)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CEntityMessageFixAngle_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

