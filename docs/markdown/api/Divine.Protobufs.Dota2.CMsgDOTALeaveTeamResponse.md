# <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse"></a> Class CMsgDOTALeaveTeamResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeaveTeamResponse : IMessage<CMsgDOTALeaveTeamResponse>, IEquatable<CMsgDOTALeaveTeamResponse>, IDeepCloneable<CMsgDOTALeaveTeamResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeaveTeamResponse](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.md)

#### Implements

IMessage<CMsgDOTALeaveTeamResponse\>, 
[IEquatable<CMsgDOTALeaveTeamResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeaveTeamResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTALeaveTeamResponse\>\(CMsgDOTALeaveTeamResponse, params CMsgDOTALeaveTeamResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse__ctor"></a> CMsgDOTALeaveTeamResponse\(\)

```csharp
public CMsgDOTALeaveTeamResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_"></a> CMsgDOTALeaveTeamResponse\(CMsgDOTALeaveTeamResponse\)

```csharp
public CMsgDOTALeaveTeamResponse(CMsgDOTALeaveTeamResponse other)
```

#### Parameters

`other` [CMsgDOTALeaveTeamResponse](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeaveTeamResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeaveTeamResponse](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_Result"></a> Result

```csharp
public CMsgDOTALeaveTeamResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgDOTALeaveTeamResponse](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeaveTeamResponse Clone()
```

#### Returns

 [CMsgDOTALeaveTeamResponse](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_"></a> Equals\(CMsgDOTALeaveTeamResponse\)

```csharp
public bool Equals(CMsgDOTALeaveTeamResponse other)
```

#### Parameters

`other` [CMsgDOTALeaveTeamResponse](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_"></a> MergeFrom\(CMsgDOTALeaveTeamResponse\)

```csharp
public void MergeFrom(CMsgDOTALeaveTeamResponse other)
```

#### Parameters

`other` [CMsgDOTALeaveTeamResponse](Divine.Protobufs.Dota2.CMsgDOTALeaveTeamResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeamResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

