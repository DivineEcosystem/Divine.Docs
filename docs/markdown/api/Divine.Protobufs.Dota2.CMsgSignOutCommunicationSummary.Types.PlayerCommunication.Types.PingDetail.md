# <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail"></a> Class CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail : IMessage<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail>, IEquatable<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail>, IDeepCloneable<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail.md)

#### Implements

IMessage<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail\>, 
[IEquatable<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail\>, 
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
[EnumerableExtensions.In<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail\>\(CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail, params CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail__ctor"></a> PingDetail\(\)

```csharp
public PingDetail()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail__ctor_Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_"></a> PingDetail\(PingDetail\)

```csharp
public PingDetail(CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail other)
```

#### Parameters

`other` [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.md).[PlayerCommunication](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.md).[PingDetail](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_CountFieldNumber"></a> CountFieldNumber

```csharp
public const int CountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_Count"></a> Count

```csharp
public uint Count { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_HasCount"></a> HasCount

```csharp
public bool HasCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.md).[PlayerCommunication](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.md).[PingDetail](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_Type"></a> Type

```csharp
public uint Type { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_ClearCount"></a> ClearCount\(\)

```csharp
public void ClearCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_Clone"></a> Clone\(\)

```csharp
public CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail Clone()
```

#### Returns

 [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.md).[PlayerCommunication](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.md).[PingDetail](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_Equals_Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_"></a> Equals\(PingDetail\)

```csharp
public bool Equals(CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail other)
```

#### Parameters

`other` [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.md).[PlayerCommunication](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.md).[PingDetail](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_MergeFrom_Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_"></a> MergeFrom\(PingDetail\)

```csharp
public void MergeFrom(CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail other)
```

#### Parameters

`other` [CMsgSignOutCommunicationSummary](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.md).[PlayerCommunication](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.md).[Types](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.md).[PingDetail](Divine.Protobufs.Dota2.CMsgSignOutCommunicationSummary.Types.PlayerCommunication.Types.PingDetail.md)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSignOutCommunicationSummary_Types_PlayerCommunication_Types_PingDetail_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

