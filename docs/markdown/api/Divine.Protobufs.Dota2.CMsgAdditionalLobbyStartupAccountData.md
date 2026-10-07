# <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData"></a> Class CMsgAdditionalLobbyStartupAccountData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAdditionalLobbyStartupAccountData : IMessage<CMsgAdditionalLobbyStartupAccountData>, IEquatable<CMsgAdditionalLobbyStartupAccountData>, IDeepCloneable<CMsgAdditionalLobbyStartupAccountData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md)

#### Implements

IMessage<CMsgAdditionalLobbyStartupAccountData\>, 
[IEquatable<CMsgAdditionalLobbyStartupAccountData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAdditionalLobbyStartupAccountData\>, 
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
[EnumerableExtensions.In<CMsgAdditionalLobbyStartupAccountData\>\(CMsgAdditionalLobbyStartupAccountData, params CMsgAdditionalLobbyStartupAccountData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData__ctor"></a> CMsgAdditionalLobbyStartupAccountData\(\)

```csharp
public CMsgAdditionalLobbyStartupAccountData()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData__ctor_Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_"></a> CMsgAdditionalLobbyStartupAccountData\(CMsgAdditionalLobbyStartupAccountData\)

```csharp
public CMsgAdditionalLobbyStartupAccountData(CMsgAdditionalLobbyStartupAccountData other)
```

#### Parameters

`other` [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_PlusDataFieldNumber"></a> PlusDataFieldNumber

```csharp
public const int PlusDataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_UnlockedChatWheelMessageRangesFieldNumber"></a> UnlockedChatWheelMessageRangesFieldNumber

```csharp
public const int UnlockedChatWheelMessageRangesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_UnlockedPingWheelMessageRangesFieldNumber"></a> UnlockedPingWheelMessageRangesFieldNumber

```csharp
public const int UnlockedPingWheelMessageRangesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAdditionalLobbyStartupAccountData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_PlusData"></a> PlusData

```csharp
public CMsgLobbyPlayerPlusSubscriptionData PlusData { get; set; }
```

#### Property Value

 [CMsgLobbyPlayerPlusSubscriptionData](Divine.Protobufs.Dota2.CMsgLobbyPlayerPlusSubscriptionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_UnlockedChatWheelMessageRanges"></a> UnlockedChatWheelMessageRanges

```csharp
public RepeatedField<CMsgAdditionalLobbyStartupAccountData.Types.ChatWheelMessageRange> UnlockedChatWheelMessageRanges { get; }
```

#### Property Value

 RepeatedField<[CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md).[Types](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.md).[ChatWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.ChatWheelMessageRange.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_UnlockedPingWheelMessageRanges"></a> UnlockedPingWheelMessageRanges

```csharp
public RepeatedField<CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange> UnlockedPingWheelMessageRanges { get; }
```

#### Property Value

 RepeatedField<[CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md).[Types](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.md).[PingWheelMessageRange](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.Types.PingWheelMessageRange.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Clone"></a> Clone\(\)

```csharp
public CMsgAdditionalLobbyStartupAccountData Clone()
```

#### Returns

 [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_Equals_Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_"></a> Equals\(CMsgAdditionalLobbyStartupAccountData\)

```csharp
public bool Equals(CMsgAdditionalLobbyStartupAccountData other)
```

#### Parameters

`other` [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_MergeFrom_Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_"></a> MergeFrom\(CMsgAdditionalLobbyStartupAccountData\)

```csharp
public void MergeFrom(CMsgAdditionalLobbyStartupAccountData other)
```

#### Parameters

`other` [CMsgAdditionalLobbyStartupAccountData](Divine.Protobufs.Dota2.CMsgAdditionalLobbyStartupAccountData.md)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAdditionalLobbyStartupAccountData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

