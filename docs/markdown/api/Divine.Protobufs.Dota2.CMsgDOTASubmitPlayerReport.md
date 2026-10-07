# <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport"></a> Class CMsgDOTASubmitPlayerReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASubmitPlayerReport : IMessage<CMsgDOTASubmitPlayerReport>, IEquatable<CMsgDOTASubmitPlayerReport>, IDeepCloneable<CMsgDOTASubmitPlayerReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASubmitPlayerReport](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReport.md)

#### Implements

IMessage<CMsgDOTASubmitPlayerReport\>, 
[IEquatable<CMsgDOTASubmitPlayerReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASubmitPlayerReport\>, 
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
[EnumerableExtensions.In<CMsgDOTASubmitPlayerReport\>\(CMsgDOTASubmitPlayerReport, params CMsgDOTASubmitPlayerReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport__ctor"></a> CMsgDOTASubmitPlayerReport\(\)

```csharp
public CMsgDOTASubmitPlayerReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport__ctor_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_"></a> CMsgDOTASubmitPlayerReport\(CMsgDOTASubmitPlayerReport\)

```csharp
public CMsgDOTASubmitPlayerReport(CMsgDOTASubmitPlayerReport other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReport](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_CommentFieldNumber"></a> CommentFieldNumber

```csharp
public const int CommentFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_LobbyIdFieldNumber"></a> LobbyIdFieldNumber

```csharp
public const int LobbyIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_ReportFlagsFieldNumber"></a> ReportFlagsFieldNumber

```csharp
public const int ReportFlagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_TargetAccountIdFieldNumber"></a> TargetAccountIdFieldNumber

```csharp
public const int TargetAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_Comment"></a> Comment

```csharp
public string Comment { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_HasComment"></a> HasComment

```csharp
public bool HasComment { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_HasLobbyId"></a> HasLobbyId

```csharp
public bool HasLobbyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_HasReportFlags"></a> HasReportFlags

```csharp
public bool HasReportFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_HasTargetAccountId"></a> HasTargetAccountId

```csharp
public bool HasTargetAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_LobbyId"></a> LobbyId

```csharp
public ulong LobbyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASubmitPlayerReport> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASubmitPlayerReport](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReport.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_ReportFlags"></a> ReportFlags

```csharp
public uint ReportFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_TargetAccountId"></a> TargetAccountId

```csharp
public uint TargetAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_ClearComment"></a> ClearComment\(\)

```csharp
public void ClearComment()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_ClearLobbyId"></a> ClearLobbyId\(\)

```csharp
public void ClearLobbyId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_ClearReportFlags"></a> ClearReportFlags\(\)

```csharp
public void ClearReportFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_ClearTargetAccountId"></a> ClearTargetAccountId\(\)

```csharp
public void ClearTargetAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASubmitPlayerReport Clone()
```

#### Returns

 [CMsgDOTASubmitPlayerReport](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_Equals_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_"></a> Equals\(CMsgDOTASubmitPlayerReport\)

```csharp
public bool Equals(CMsgDOTASubmitPlayerReport other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReport](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_"></a> MergeFrom\(CMsgDOTASubmitPlayerReport\)

```csharp
public void MergeFrom(CMsgDOTASubmitPlayerReport other)
```

#### Parameters

`other` [CMsgDOTASubmitPlayerReport](Divine.Protobufs.Dota2.CMsgDOTASubmitPlayerReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASubmitPlayerReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

