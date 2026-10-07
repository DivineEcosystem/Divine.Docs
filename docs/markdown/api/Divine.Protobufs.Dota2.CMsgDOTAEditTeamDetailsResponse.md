# <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse"></a> Class CMsgDOTAEditTeamDetailsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAEditTeamDetailsResponse : IMessage<CMsgDOTAEditTeamDetailsResponse>, IEquatable<CMsgDOTAEditTeamDetailsResponse>, IDeepCloneable<CMsgDOTAEditTeamDetailsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAEditTeamDetailsResponse](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.md)

#### Implements

IMessage<CMsgDOTAEditTeamDetailsResponse\>, 
[IEquatable<CMsgDOTAEditTeamDetailsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAEditTeamDetailsResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAEditTeamDetailsResponse\>\(CMsgDOTAEditTeamDetailsResponse, params CMsgDOTAEditTeamDetailsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse__ctor"></a> CMsgDOTAEditTeamDetailsResponse\(\)

```csharp
public CMsgDOTAEditTeamDetailsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_"></a> CMsgDOTAEditTeamDetailsResponse\(CMsgDOTAEditTeamDetailsResponse\)

```csharp
public CMsgDOTAEditTeamDetailsResponse(CMsgDOTAEditTeamDetailsResponse other)
```

#### Parameters

`other` [CMsgDOTAEditTeamDetailsResponse](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAEditTeamDetailsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAEditTeamDetailsResponse](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_Result"></a> Result

```csharp
public CMsgDOTAEditTeamDetailsResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgDOTAEditTeamDetailsResponse](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAEditTeamDetailsResponse Clone()
```

#### Returns

 [CMsgDOTAEditTeamDetailsResponse](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_"></a> Equals\(CMsgDOTAEditTeamDetailsResponse\)

```csharp
public bool Equals(CMsgDOTAEditTeamDetailsResponse other)
```

#### Parameters

`other` [CMsgDOTAEditTeamDetailsResponse](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_"></a> MergeFrom\(CMsgDOTAEditTeamDetailsResponse\)

```csharp
public void MergeFrom(CMsgDOTAEditTeamDetailsResponse other)
```

#### Parameters

`other` [CMsgDOTAEditTeamDetailsResponse](Divine.Protobufs.Dota2.CMsgDOTAEditTeamDetailsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAEditTeamDetailsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

