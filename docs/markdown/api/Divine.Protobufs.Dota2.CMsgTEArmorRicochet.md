# <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet"></a> Class CMsgTEArmorRicochet

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTEArmorRicochet : IMessage<CMsgTEArmorRicochet>, IEquatable<CMsgTEArmorRicochet>, IDeepCloneable<CMsgTEArmorRicochet>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTEArmorRicochet](Divine.Protobufs.Dota2.CMsgTEArmorRicochet.md)

#### Implements

IMessage<CMsgTEArmorRicochet\>, 
[IEquatable<CMsgTEArmorRicochet\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTEArmorRicochet\>, 
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
[EnumerableExtensions.In<CMsgTEArmorRicochet\>\(CMsgTEArmorRicochet, params CMsgTEArmorRicochet\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet__ctor"></a> CMsgTEArmorRicochet\(\)

```csharp
public CMsgTEArmorRicochet()
```

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet__ctor_Divine_Protobufs_Dota2_CMsgTEArmorRicochet_"></a> CMsgTEArmorRicochet\(CMsgTEArmorRicochet\)

```csharp
public CMsgTEArmorRicochet(CMsgTEArmorRicochet other)
```

#### Parameters

`other` [CMsgTEArmorRicochet](Divine.Protobufs.Dota2.CMsgTEArmorRicochet.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_DirFieldNumber"></a> DirFieldNumber

```csharp
public const int DirFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_PosFieldNumber"></a> PosFieldNumber

```csharp
public const int PosFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_Dir"></a> Dir

```csharp
public CMsgVector Dir { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTEArmorRicochet> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTEArmorRicochet](Divine.Protobufs.Dota2.CMsgTEArmorRicochet.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_Pos"></a> Pos

```csharp
public CMsgVector Pos { get; set; }
```

#### Property Value

 [CMsgVector](Divine.Protobufs.Dota2.CMsgVector.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_Clone"></a> Clone\(\)

```csharp
public CMsgTEArmorRicochet Clone()
```

#### Returns

 [CMsgTEArmorRicochet](Divine.Protobufs.Dota2.CMsgTEArmorRicochet.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_Equals_Divine_Protobufs_Dota2_CMsgTEArmorRicochet_"></a> Equals\(CMsgTEArmorRicochet\)

```csharp
public bool Equals(CMsgTEArmorRicochet other)
```

#### Parameters

`other` [CMsgTEArmorRicochet](Divine.Protobufs.Dota2.CMsgTEArmorRicochet.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_MergeFrom_Divine_Protobufs_Dota2_CMsgTEArmorRicochet_"></a> MergeFrom\(CMsgTEArmorRicochet\)

```csharp
public void MergeFrom(CMsgTEArmorRicochet other)
```

#### Parameters

`other` [CMsgTEArmorRicochet](Divine.Protobufs.Dota2.CMsgTEArmorRicochet.md)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTEArmorRicochet_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

