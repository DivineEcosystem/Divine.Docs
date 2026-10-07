# <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected"></a> Class CMsgLeaverDetected

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLeaverDetected : IMessage<CMsgLeaverDetected>, IEquatable<CMsgLeaverDetected>, IDeepCloneable<CMsgLeaverDetected>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLeaverDetected](Divine.Protobufs.Dota2.CMsgLeaverDetected.md)

#### Implements

IMessage<CMsgLeaverDetected\>, 
[IEquatable<CMsgLeaverDetected\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLeaverDetected\>, 
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
[EnumerableExtensions.In<CMsgLeaverDetected\>\(CMsgLeaverDetected, params CMsgLeaverDetected\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected__ctor"></a> CMsgLeaverDetected\(\)

```csharp
public CMsgLeaverDetected()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected__ctor_Divine_Protobufs_Dota2_CMsgLeaverDetected_"></a> CMsgLeaverDetected\(CMsgLeaverDetected\)

```csharp
public CMsgLeaverDetected(CMsgLeaverDetected other)
```

#### Parameters

`other` [CMsgLeaverDetected](Divine.Protobufs.Dota2.CMsgLeaverDetected.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_DisconnectReasonFieldNumber"></a> DisconnectReasonFieldNumber

```csharp
public const int DisconnectReasonFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_LeaverStateFieldNumber"></a> LeaverStateFieldNumber

```csharp
public const int LeaverStateFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_LeaverStatusFieldNumber"></a> LeaverStatusFieldNumber

```csharp
public const int LeaverStatusFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_PoorNetworkConditionsFieldNumber"></a> PoorNetworkConditionsFieldNumber

```csharp
public const int PoorNetworkConditionsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_ServerClusterFieldNumber"></a> ServerClusterFieldNumber

```csharp
public const int ServerClusterFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_SteamIdFieldNumber"></a> SteamIdFieldNumber

```csharp
public const int SteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_DisconnectReason"></a> DisconnectReason

```csharp
public ENetworkDisconnectionReason DisconnectReason { get; set; }
```

#### Property Value

 [ENetworkDisconnectionReason](Divine.Protobufs.Dota2.ENetworkDisconnectionReason.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_HasDisconnectReason"></a> HasDisconnectReason

```csharp
public bool HasDisconnectReason { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_HasLeaverStatus"></a> HasLeaverStatus

```csharp
public bool HasLeaverStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_HasServerCluster"></a> HasServerCluster

```csharp
public bool HasServerCluster { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_HasSteamId"></a> HasSteamId

```csharp
public bool HasSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_LeaverState"></a> LeaverState

```csharp
public CMsgLeaverState LeaverState { get; set; }
```

#### Property Value

 [CMsgLeaverState](Divine.Protobufs.Dota2.CMsgLeaverState.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_LeaverStatus"></a> LeaverStatus

```csharp
public DOTALeaverStatus_t LeaverStatus { get; set; }
```

#### Property Value

 [DOTALeaverStatus\_t](Divine.Protobufs.Dota2.DOTALeaverStatus\_t.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLeaverDetected> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLeaverDetected](Divine.Protobufs.Dota2.CMsgLeaverDetected.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_PoorNetworkConditions"></a> PoorNetworkConditions

```csharp
public CMsgPoorNetworkConditions PoorNetworkConditions { get; set; }
```

#### Property Value

 [CMsgPoorNetworkConditions](Divine.Protobufs.Dota2.CMsgPoorNetworkConditions.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_ServerCluster"></a> ServerCluster

```csharp
public uint ServerCluster { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_SteamId"></a> SteamId

```csharp
public ulong SteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_ClearDisconnectReason"></a> ClearDisconnectReason\(\)

```csharp
public void ClearDisconnectReason()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_ClearLeaverStatus"></a> ClearLeaverStatus\(\)

```csharp
public void ClearLeaverStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_ClearServerCluster"></a> ClearServerCluster\(\)

```csharp
public void ClearServerCluster()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_ClearSteamId"></a> ClearSteamId\(\)

```csharp
public void ClearSteamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_Clone"></a> Clone\(\)

```csharp
public CMsgLeaverDetected Clone()
```

#### Returns

 [CMsgLeaverDetected](Divine.Protobufs.Dota2.CMsgLeaverDetected.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_Equals_Divine_Protobufs_Dota2_CMsgLeaverDetected_"></a> Equals\(CMsgLeaverDetected\)

```csharp
public bool Equals(CMsgLeaverDetected other)
```

#### Parameters

`other` [CMsgLeaverDetected](Divine.Protobufs.Dota2.CMsgLeaverDetected.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_MergeFrom_Divine_Protobufs_Dota2_CMsgLeaverDetected_"></a> MergeFrom\(CMsgLeaverDetected\)

```csharp
public void MergeFrom(CMsgLeaverDetected other)
```

#### Parameters

`other` [CMsgLeaverDetected](Divine.Protobufs.Dota2.CMsgLeaverDetected.md)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLeaverDetected_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

