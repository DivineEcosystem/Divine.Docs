# <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest"></a> Class CMsgGCToClientBattlePassRollupListRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientBattlePassRollupListRequest : IMessage<CMsgGCToClientBattlePassRollupListRequest>, IEquatable<CMsgGCToClientBattlePassRollupListRequest>, IDeepCloneable<CMsgGCToClientBattlePassRollupListRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientBattlePassRollupListRequest](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListRequest.md)

#### Implements

IMessage<CMsgGCToClientBattlePassRollupListRequest\>, 
[IEquatable<CMsgGCToClientBattlePassRollupListRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientBattlePassRollupListRequest\>, 
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
[EnumerableExtensions.In<CMsgGCToClientBattlePassRollupListRequest\>\(CMsgGCToClientBattlePassRollupListRequest, params CMsgGCToClientBattlePassRollupListRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest__ctor"></a> CMsgGCToClientBattlePassRollupListRequest\(\)

```csharp
public CMsgGCToClientBattlePassRollupListRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest__ctor_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_"></a> CMsgGCToClientBattlePassRollupListRequest\(CMsgGCToClientBattlePassRollupListRequest\)

```csharp
public CMsgGCToClientBattlePassRollupListRequest(CMsgGCToClientBattlePassRollupListRequest other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListRequest](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientBattlePassRollupListRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientBattlePassRollupListRequest](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientBattlePassRollupListRequest Clone()
```

#### Returns

 [CMsgGCToClientBattlePassRollupListRequest](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_Equals_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_"></a> Equals\(CMsgGCToClientBattlePassRollupListRequest\)

```csharp
public bool Equals(CMsgGCToClientBattlePassRollupListRequest other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListRequest](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_"></a> MergeFrom\(CMsgGCToClientBattlePassRollupListRequest\)

```csharp
public void MergeFrom(CMsgGCToClientBattlePassRollupListRequest other)
```

#### Parameters

`other` [CMsgGCToClientBattlePassRollupListRequest](Divine.Protobufs.Dota2.CMsgGCToClientBattlePassRollupListRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientBattlePassRollupListRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

