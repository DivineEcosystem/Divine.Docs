# <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse"></a> Class CMsgDOTATransferTeamAdminResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATransferTeamAdminResponse : IMessage<CMsgDOTATransferTeamAdminResponse>, IEquatable<CMsgDOTATransferTeamAdminResponse>, IDeepCloneable<CMsgDOTATransferTeamAdminResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATransferTeamAdminResponse](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.md)

#### Implements

IMessage<CMsgDOTATransferTeamAdminResponse\>, 
[IEquatable<CMsgDOTATransferTeamAdminResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATransferTeamAdminResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTATransferTeamAdminResponse\>\(CMsgDOTATransferTeamAdminResponse, params CMsgDOTATransferTeamAdminResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse__ctor"></a> CMsgDOTATransferTeamAdminResponse\(\)

```csharp
public CMsgDOTATransferTeamAdminResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_"></a> CMsgDOTATransferTeamAdminResponse\(CMsgDOTATransferTeamAdminResponse\)

```csharp
public CMsgDOTATransferTeamAdminResponse(CMsgDOTATransferTeamAdminResponse other)
```

#### Parameters

`other` [CMsgDOTATransferTeamAdminResponse](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATransferTeamAdminResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATransferTeamAdminResponse](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_Result"></a> Result

```csharp
public CMsgDOTATransferTeamAdminResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgDOTATransferTeamAdminResponse](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATransferTeamAdminResponse Clone()
```

#### Returns

 [CMsgDOTATransferTeamAdminResponse](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_"></a> Equals\(CMsgDOTATransferTeamAdminResponse\)

```csharp
public bool Equals(CMsgDOTATransferTeamAdminResponse other)
```

#### Parameters

`other` [CMsgDOTATransferTeamAdminResponse](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_"></a> MergeFrom\(CMsgDOTATransferTeamAdminResponse\)

```csharp
public void MergeFrom(CMsgDOTATransferTeamAdminResponse other)
```

#### Parameters

`other` [CMsgDOTATransferTeamAdminResponse](Divine.Protobufs.Dota2.CMsgDOTATransferTeamAdminResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATransferTeamAdminResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

