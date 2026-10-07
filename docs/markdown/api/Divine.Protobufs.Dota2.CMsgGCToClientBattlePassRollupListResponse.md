# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse"></a> Class CMsgGCToClientBattlePassRollupListResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollupListResponse : IMessage<CMsgGCToClientBattlePassRollupListResponse>, IEquatable<CMsgGCToClientBattlePassRollupListResponse>, IDeepCloneable<CMsgGCToClientBattlePassRollupListResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollupListResponse\>, 
[IEquatable<CMsgGCToClientBattlePassRollupListResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollupListResponse\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollupListResponse\>\(CMsgGCToClientBattlePassRollupListResponse, params CMsgGCToClientBattlePassRollupListResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse__ctor"></a> CMsgGCToClientBattlePassRollupListResponse\(\)

```csharp
public CMsgGCToClientBattlePassRollupListResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_"></a> CMsgGCToClientBattlePassRollupListResponse\(CMsgGCToClientBattlePassRollupListResponse\)

```csharp
public CMsgGCToClientBattlePassRollupListResponse(CMsgGCToClientBattlePassRollupListResponse other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_EventInfoFieldNumber"></a> EventInfoFieldNumber

```csharp
public const int EventInfoFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_EventInfo"></a> EventInfo

```csharp
public RepeatedField<CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo> EventInfo { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.md).[EventInfo](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.Types.EventInfo.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollupListResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollupListResponse Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_"></a> Equals\(CMsgGCToClientBattlePassRollupListResponse\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollupListResponse other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_"></a> MergeFrom\(CMsgGCToClientBattlePassRollupListResponse\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollupListResponse other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListResponse](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

