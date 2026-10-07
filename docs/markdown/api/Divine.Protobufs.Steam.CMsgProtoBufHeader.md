# <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader"></a> Class CMsgProtoBufHeader

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgProtoBufHeader : IMessage<CMsgProtoBufHeader>, IEquatable<CMsgProtoBufHeader>, IDeepCloneable<CMsgProtoBufHeader>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgProtoBufHeader](Divine.Protobufs.Steam.CMsgProtoBufHeader.md)

#### Implements

IMessage<CMsgProtoBufHeader\>, 
[IEquatable<CMsgProtoBufHeader\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgProtoBufHeader\>, 
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
[EnumerableExtensions.In<CMsgProtoBufHeader\>\(CMsgProtoBufHeader, params CMsgProtoBufHeader\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader__ctor"></a> CMsgProtoBufHeader\(\)

```csharp
public CMsgProtoBufHeader()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader__ctor_Divine_Protobufs_Steam_CMsgProtoBufHeader_"></a> CMsgProtoBufHeader\(CMsgProtoBufHeader\)

```csharp
public CMsgProtoBufHeader(CMsgProtoBufHeader other)
```

#### Parameters

`other` [CMsgProtoBufHeader](Divine.Protobufs.Steam.CMsgProtoBufHeader.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClientSessionIdFieldNumber"></a> ClientSessionIdFieldNumber

```csharp
public const int ClientSessionIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClientSteamIdFieldNumber"></a> ClientSteamIdFieldNumber

```csharp
public const int ClientSteamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 13
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ErrorMessageFieldNumber"></a> ErrorMessageFieldNumber

```csharp
public const int ErrorMessageFieldNumber = 14
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_GcDirIndexSourceFieldNumber"></a> GcDirIndexSourceFieldNumber

```csharp
public const int GcDirIndexSourceFieldNumber = 201
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_GcMsgSrcFieldNumber"></a> GcMsgSrcFieldNumber

```csharp
public const int GcMsgSrcFieldNumber = 200
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_JobIdSourceFieldNumber"></a> JobIdSourceFieldNumber

```csharp
public const int JobIdSourceFieldNumber = 10
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_JobIdTargetFieldNumber"></a> JobIdTargetFieldNumber

```csharp
public const int JobIdTargetFieldNumber = 11
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_SourceAppIdFieldNumber"></a> SourceAppIdFieldNumber

```csharp
public const int SourceAppIdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_TargetJobNameFieldNumber"></a> TargetJobNameFieldNumber

```csharp
public const int TargetJobNameFieldNumber = 12
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClientSessionId"></a> ClientSessionId

```csharp
public int ClientSessionId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClientSteamId"></a> ClientSteamId

```csharp
public ulong ClientSteamId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_Eresult"></a> Eresult

```csharp
public int Eresult { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ErrorMessage"></a> ErrorMessage

```csharp
public string ErrorMessage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_GcDirIndexSource"></a> GcDirIndexSource

```csharp
public int GcDirIndexSource { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_GcMsgSrc"></a> GcMsgSrc

```csharp
public GCProtoBufMsgSrc GcMsgSrc { get; set; }
```

#### Property Value

 [GCProtoBufMsgSrc](Divine.Protobufs.Steam.GCProtoBufMsgSrc.md)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasClientSessionId"></a> HasClientSessionId

```csharp
public bool HasClientSessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasClientSteamId"></a> HasClientSteamId

```csharp
public bool HasClientSteamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasErrorMessage"></a> HasErrorMessage

```csharp
public bool HasErrorMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasGcDirIndexSource"></a> HasGcDirIndexSource

```csharp
public bool HasGcDirIndexSource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasGcMsgSrc"></a> HasGcMsgSrc

```csharp
public bool HasGcMsgSrc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasJobIdSource"></a> HasJobIdSource

```csharp
public bool HasJobIdSource { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasJobIdTarget"></a> HasJobIdTarget

```csharp
public bool HasJobIdTarget { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasSourceAppId"></a> HasSourceAppId

```csharp
public bool HasSourceAppId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_HasTargetJobName"></a> HasTargetJobName

```csharp
public bool HasTargetJobName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_JobIdSource"></a> JobIdSource

```csharp
public ulong JobIdSource { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_JobIdTarget"></a> JobIdTarget

```csharp
public ulong JobIdTarget { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_Parser"></a> Parser

```csharp
public static MessageParser<CMsgProtoBufHeader> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgProtoBufHeader](Divine.Protobufs.Steam.CMsgProtoBufHeader.md)\>

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_SourceAppId"></a> SourceAppId

```csharp
public uint SourceAppId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_TargetJobName"></a> TargetJobName

```csharp
public string TargetJobName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearClientSessionId"></a> ClearClientSessionId\(\)

```csharp
public void ClearClientSessionId()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearClientSteamId"></a> ClearClientSteamId\(\)

```csharp
public void ClearClientSteamId()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearErrorMessage"></a> ClearErrorMessage\(\)

```csharp
public void ClearErrorMessage()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearGcDirIndexSource"></a> ClearGcDirIndexSource\(\)

```csharp
public void ClearGcDirIndexSource()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearGcMsgSrc"></a> ClearGcMsgSrc\(\)

```csharp
public void ClearGcMsgSrc()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearJobIdSource"></a> ClearJobIdSource\(\)

```csharp
public void ClearJobIdSource()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearJobIdTarget"></a> ClearJobIdTarget\(\)

```csharp
public void ClearJobIdTarget()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearSourceAppId"></a> ClearSourceAppId\(\)

```csharp
public void ClearSourceAppId()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ClearTargetJobName"></a> ClearTargetJobName\(\)

```csharp
public void ClearTargetJobName()
```

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_Clone"></a> Clone\(\)

```csharp
public CMsgProtoBufHeader Clone()
```

#### Returns

 [CMsgProtoBufHeader](Divine.Protobufs.Steam.CMsgProtoBufHeader.md)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_Equals_Divine_Protobufs_Steam_CMsgProtoBufHeader_"></a> Equals\(CMsgProtoBufHeader\)

```csharp
public bool Equals(CMsgProtoBufHeader other)
```

#### Parameters

`other` [CMsgProtoBufHeader](Divine.Protobufs.Steam.CMsgProtoBufHeader.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_MergeFrom_Divine_Protobufs_Steam_CMsgProtoBufHeader_"></a> MergeFrom\(CMsgProtoBufHeader\)

```csharp
public void MergeFrom(CMsgProtoBufHeader other)
```

#### Parameters

`other` [CMsgProtoBufHeader](Divine.Protobufs.Steam.CMsgProtoBufHeader.md)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgProtoBufHeader_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

