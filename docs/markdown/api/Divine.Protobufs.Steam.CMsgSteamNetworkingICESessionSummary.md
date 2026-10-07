# <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary"></a> Class CMsgSteamNetworkingICESessionSummary

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamNetworkingICESessionSummary : IMessage<CMsgSteamNetworkingICESessionSummary>, IEquatable<CMsgSteamNetworkingICESessionSummary>, IDeepCloneable<CMsgSteamNetworkingICESessionSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamNetworkingICESessionSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingICESessionSummary.md)

#### Implements

IMessage<CMsgSteamNetworkingICESessionSummary\>, 
[IEquatable<CMsgSteamNetworkingICESessionSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamNetworkingICESessionSummary\>, 
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
[EnumerableExtensions.In<CMsgSteamNetworkingICESessionSummary\>\(CMsgSteamNetworkingICESessionSummary, params CMsgSteamNetworkingICESessionSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary__ctor"></a> CMsgSteamNetworkingICESessionSummary\(\)

```csharp
public CMsgSteamNetworkingICESessionSummary()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary__ctor_Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_"></a> CMsgSteamNetworkingICESessionSummary\(CMsgSteamNetworkingICESessionSummary\)

```csharp
public CMsgSteamNetworkingICESessionSummary(CMsgSteamNetworkingICESessionSummary other)
```

#### Parameters

`other` [CMsgSteamNetworkingICESessionSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingICESessionSummary.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestPingFieldNumber"></a> BestPingFieldNumber

```csharp
public const int BestPingFieldNumber = 17
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestRouteKindFieldNumber"></a> BestRouteKindFieldNumber

```csharp
public const int BestRouteKindFieldNumber = 16
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestScoreFieldNumber"></a> BestScoreFieldNumber

```csharp
public const int BestScoreFieldNumber = 18
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestTimeFieldNumber"></a> BestTimeFieldNumber

```csharp
public const int BestTimeFieldNumber = 19
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_FailureReasonCodeFieldNumber"></a> FailureReasonCodeFieldNumber

```csharp
public const int FailureReasonCodeFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_IceEnableVarFieldNumber"></a> IceEnableVarFieldNumber

```csharp
public const int IceEnableVarFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_InitialPingFieldNumber"></a> InitialPingFieldNumber

```csharp
public const int InitialPingFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_InitialRouteKindFieldNumber"></a> InitialRouteKindFieldNumber

```csharp
public const int InitialRouteKindFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_InitialScoreFieldNumber"></a> InitialScoreFieldNumber

```csharp
public const int InitialScoreFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_LocalCandidateTypesAllowedFieldNumber"></a> LocalCandidateTypesAllowedFieldNumber

```csharp
public const int LocalCandidateTypesAllowedFieldNumber = 15
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_LocalCandidateTypesFieldNumber"></a> LocalCandidateTypesFieldNumber

```csharp
public const int LocalCandidateTypesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_NegotiationMsFieldNumber"></a> NegotiationMsFieldNumber

```csharp
public const int NegotiationMsFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_RemoteCandidateTypesFieldNumber"></a> RemoteCandidateTypesFieldNumber

```csharp
public const int RemoteCandidateTypesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_SelectedSecondsFieldNumber"></a> SelectedSecondsFieldNumber

```csharp
public const int SelectedSecondsFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_UserSettingsFieldNumber"></a> UserSettingsFieldNumber

```csharp
public const int UserSettingsFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestPing"></a> BestPing

```csharp
public uint BestPing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestRouteKind"></a> BestRouteKind

```csharp
public uint BestRouteKind { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestScore"></a> BestScore

```csharp
public uint BestScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_BestTime"></a> BestTime

```csharp
public uint BestTime { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_FailureReasonCode"></a> FailureReasonCode

```csharp
public uint FailureReasonCode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasBestPing"></a> HasBestPing

```csharp
public bool HasBestPing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasBestRouteKind"></a> HasBestRouteKind

```csharp
public bool HasBestRouteKind { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasBestScore"></a> HasBestScore

```csharp
public bool HasBestScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasBestTime"></a> HasBestTime

```csharp
public bool HasBestTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasFailureReasonCode"></a> HasFailureReasonCode

```csharp
public bool HasFailureReasonCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasIceEnableVar"></a> HasIceEnableVar

```csharp
public bool HasIceEnableVar { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasInitialPing"></a> HasInitialPing

```csharp
public bool HasInitialPing { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasInitialRouteKind"></a> HasInitialRouteKind

```csharp
public bool HasInitialRouteKind { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasInitialScore"></a> HasInitialScore

```csharp
public bool HasInitialScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasLocalCandidateTypes"></a> HasLocalCandidateTypes

```csharp
public bool HasLocalCandidateTypes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasLocalCandidateTypesAllowed"></a> HasLocalCandidateTypesAllowed

```csharp
public bool HasLocalCandidateTypesAllowed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasNegotiationMs"></a> HasNegotiationMs

```csharp
public bool HasNegotiationMs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasRemoteCandidateTypes"></a> HasRemoteCandidateTypes

```csharp
public bool HasRemoteCandidateTypes { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasSelectedSeconds"></a> HasSelectedSeconds

```csharp
public bool HasSelectedSeconds { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_HasUserSettings"></a> HasUserSettings

```csharp
public bool HasUserSettings { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_IceEnableVar"></a> IceEnableVar

```csharp
public uint IceEnableVar { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_InitialPing"></a> InitialPing

```csharp
public uint InitialPing { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_InitialRouteKind"></a> InitialRouteKind

```csharp
public uint InitialRouteKind { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_InitialScore"></a> InitialScore

```csharp
public uint InitialScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_LocalCandidateTypes"></a> LocalCandidateTypes

```csharp
public uint LocalCandidateTypes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_LocalCandidateTypesAllowed"></a> LocalCandidateTypesAllowed

```csharp
public uint LocalCandidateTypesAllowed { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_NegotiationMs"></a> NegotiationMs

```csharp
public uint NegotiationMs { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamNetworkingICESessionSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamNetworkingICESessionSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingICESessionSummary.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_RemoteCandidateTypes"></a> RemoteCandidateTypes

```csharp
public uint RemoteCandidateTypes { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_SelectedSeconds"></a> SelectedSeconds

```csharp
public uint SelectedSeconds { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_UserSettings"></a> UserSettings

```csharp
public uint UserSettings { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearBestPing"></a> ClearBestPing\(\)

```csharp
public void ClearBestPing()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearBestRouteKind"></a> ClearBestRouteKind\(\)

```csharp
public void ClearBestRouteKind()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearBestScore"></a> ClearBestScore\(\)

```csharp
public void ClearBestScore()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearBestTime"></a> ClearBestTime\(\)

```csharp
public void ClearBestTime()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearFailureReasonCode"></a> ClearFailureReasonCode\(\)

```csharp
public void ClearFailureReasonCode()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearIceEnableVar"></a> ClearIceEnableVar\(\)

```csharp
public void ClearIceEnableVar()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearInitialPing"></a> ClearInitialPing\(\)

```csharp
public void ClearInitialPing()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearInitialRouteKind"></a> ClearInitialRouteKind\(\)

```csharp
public void ClearInitialRouteKind()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearInitialScore"></a> ClearInitialScore\(\)

```csharp
public void ClearInitialScore()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearLocalCandidateTypes"></a> ClearLocalCandidateTypes\(\)

```csharp
public void ClearLocalCandidateTypes()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearLocalCandidateTypesAllowed"></a> ClearLocalCandidateTypesAllowed\(\)

```csharp
public void ClearLocalCandidateTypesAllowed()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearNegotiationMs"></a> ClearNegotiationMs\(\)

```csharp
public void ClearNegotiationMs()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearRemoteCandidateTypes"></a> ClearRemoteCandidateTypes\(\)

```csharp
public void ClearRemoteCandidateTypes()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearSelectedSeconds"></a> ClearSelectedSeconds\(\)

```csharp
public void ClearSelectedSeconds()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ClearUserSettings"></a> ClearUserSettings\(\)

```csharp
public void ClearUserSettings()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_Clone"></a> Clone\(\)

```csharp
public CMsgSteamNetworkingICESessionSummary Clone()
```

#### Returns

 [CMsgSteamNetworkingICESessionSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingICESessionSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_Equals_Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_"></a> Equals\(CMsgSteamNetworkingICESessionSummary\)

```csharp
public bool Equals(CMsgSteamNetworkingICESessionSummary other)
```

#### Parameters

`other` [CMsgSteamNetworkingICESessionSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingICESessionSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_MergeFrom_Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_"></a> MergeFrom\(CMsgSteamNetworkingICESessionSummary\)

```csharp
public void MergeFrom(CMsgSteamNetworkingICESessionSummary other)
```

#### Parameters

`other` [CMsgSteamNetworkingICESessionSummary](Divine.Protobufs.Steam.CMsgSteamNetworkingICESessionSummary.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamNetworkingICESessionSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

