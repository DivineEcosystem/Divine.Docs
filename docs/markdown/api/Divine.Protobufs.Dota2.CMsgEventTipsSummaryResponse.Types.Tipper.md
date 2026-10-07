# <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper"></a> Class CMsgEventTipsSummaryResponse.Types.Tipper

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventTipsSummaryResponse.Types.Tipper : IMessage<CMsgEventTipsSummaryResponse.Types.Tipper>, IEquatable<CMsgEventTipsSummaryResponse.Types.Tipper>, IDeepCloneable<CMsgEventTipsSummaryResponse.Types.Tipper>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventTipsSummaryResponse.Types.Tipper](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.Tipper.md)

#### Implements

IMessage<CMsgEventTipsSummaryResponse.Types.Tipper\>, 
[IEquatable<CMsgEventTipsSummaryResponse.Types.Tipper\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventTipsSummaryResponse.Types.Tipper\>, 
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
[EnumerableExtensions.In<CMsgEventTipsSummaryResponse.Types.Tipper\>\(CMsgEventTipsSummaryResponse.Types.Tipper, params CMsgEventTipsSummaryResponse.Types.Tipper\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper__ctor"></a> Tipper\(\)

```csharp
public Tipper()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper__ctor_Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_"></a> Tipper\(Tipper\)

```csharp
public Tipper(CMsgEventTipsSummaryResponse.Types.Tipper other)
```

#### Parameters

`other` [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.md).[Tipper](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.Tipper.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_TipCountFieldNumber"></a> TipCountFieldNumber

```csharp
public const int TipCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_TipperAccountIdFieldNumber"></a> TipperAccountIdFieldNumber

```csharp
public const int TipperAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_HasTipCount"></a> HasTipCount

```csharp
public bool HasTipCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_HasTipperAccountId"></a> HasTipperAccountId

```csharp
public bool HasTipperAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventTipsSummaryResponse.Types.Tipper> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.md).[Tipper](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.Tipper.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_TipCount"></a> TipCount

```csharp
public uint TipCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_TipperAccountId"></a> TipperAccountId

```csharp
public uint TipperAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_ClearTipCount"></a> ClearTipCount\(\)

```csharp
public void ClearTipCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_ClearTipperAccountId"></a> ClearTipperAccountId\(\)

```csharp
public void ClearTipperAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_Clone"></a> Clone\(\)

```csharp
public CMsgEventTipsSummaryResponse.Types.Tipper Clone()
```

#### Returns

 [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.md).[Tipper](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.Tipper.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_Equals_Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_"></a> Equals\(Tipper\)

```csharp
public bool Equals(CMsgEventTipsSummaryResponse.Types.Tipper other)
```

#### Parameters

`other` [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.md).[Tipper](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.Tipper.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_MergeFrom_Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_"></a> MergeFrom\(Tipper\)

```csharp
public void MergeFrom(CMsgEventTipsSummaryResponse.Types.Tipper other)
```

#### Parameters

`other` [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.md).[Tipper](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.Tipper.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Types_Tipper_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

