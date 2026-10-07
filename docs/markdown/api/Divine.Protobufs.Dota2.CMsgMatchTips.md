# <a id="Divine_Protobufs_Dota2_CMsgMatchTips"></a> Class CMsgMatchTips

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgMatchTips : IMessage<CMsgMatchTips>, IEquatable<CMsgMatchTips>, IDeepCloneable<CMsgMatchTips>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md)

#### Implements

IMessage<CMsgMatchTips\>, 
[IEquatable<CMsgMatchTips\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgMatchTips\>, 
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
[EnumerableExtensions.In<CMsgMatchTips\>\(CMsgMatchTips, params CMsgMatchTips\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips__ctor"></a> CMsgMatchTips\(\)

```csharp
public CMsgMatchTips()
```

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips__ctor_Divine_Protobufs_Dota2_CMsgMatchTips_"></a> CMsgMatchTips\(CMsgMatchTips\)

```csharp
public CMsgMatchTips(CMsgMatchTips other)
```

#### Parameters

`other` [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_TipsFieldNumber"></a> TipsFieldNumber

```csharp
public const int TipsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Parser"></a> Parser

```csharp
public static MessageParser<CMsgMatchTips> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Tips"></a> Tips

```csharp
public RepeatedField<CMsgMatchTips.Types.SingleTip> Tips { get; }
```

#### Property Value

 RepeatedField<[CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md).[Types](Divine.Protobufs.Dota2.CMsgMatchTips.Types.md).[SingleTip](Divine.Protobufs.Dota2.CMsgMatchTips.Types.SingleTip.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Clone"></a> Clone\(\)

```csharp
public CMsgMatchTips Clone()
```

#### Returns

 [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_Equals_Divine_Protobufs_Dota2_CMsgMatchTips_"></a> Equals\(CMsgMatchTips\)

```csharp
public bool Equals(CMsgMatchTips other)
```

#### Parameters

`other` [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_MergeFrom_Divine_Protobufs_Dota2_CMsgMatchTips_"></a> MergeFrom\(CMsgMatchTips\)

```csharp
public void MergeFrom(CMsgMatchTips other)
```

#### Parameters

`other` [CMsgMatchTips](Divine.Protobufs.Dota2.CMsgMatchTips.md)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgMatchTips_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

