# <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response"></a> Class CHelpRequestLogs\_UploadUserApplicationLog\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CHelpRequestLogs_UploadUserApplicationLog_Response : IMessage<CHelpRequestLogs_UploadUserApplicationLog_Response>, IEquatable<CHelpRequestLogs_UploadUserApplicationLog_Response>, IDeepCloneable<CHelpRequestLogs_UploadUserApplicationLog_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CHelpRequestLogs\_UploadUserApplicationLog\_Response](Divine.Protobufs.Steam.CHelpRequestLogs\_UploadUserApplicationLog\_Response.md)

#### Implements

IMessage<CHelpRequestLogs\_UploadUserApplicationLog\_Response\>, 
[IEquatable<CHelpRequestLogs\_UploadUserApplicationLog\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CHelpRequestLogs\_UploadUserApplicationLog\_Response\>, 
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
[EnumerableExtensions.In<CHelpRequestLogs\_UploadUserApplicationLog\_Response\>\(CHelpRequestLogs\_UploadUserApplicationLog\_Response, params CHelpRequestLogs\_UploadUserApplicationLog\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response__ctor"></a> CHelpRequestLogs\_UploadUserApplicationLog\_Response\(\)

```csharp
public CHelpRequestLogs_UploadUserApplicationLog_Response()
```

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response__ctor_Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_"></a> CHelpRequestLogs\_UploadUserApplicationLog\_Response\(CHelpRequestLogs\_UploadUserApplicationLog\_Response\)

```csharp
public CHelpRequestLogs_UploadUserApplicationLog_Response(CHelpRequestLogs_UploadUserApplicationLog_Response other)
```

#### Parameters

`other` [CHelpRequestLogs\_UploadUserApplicationLog\_Response](Divine.Protobufs.Steam.CHelpRequestLogs\_UploadUserApplicationLog\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_Id"></a> Id

```csharp
public ulong Id { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_Parser"></a> Parser

```csharp
public static MessageParser<CHelpRequestLogs_UploadUserApplicationLog_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CHelpRequestLogs\_UploadUserApplicationLog\_Response](Divine.Protobufs.Steam.CHelpRequestLogs\_UploadUserApplicationLog\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_Clone"></a> Clone\(\)

```csharp
public CHelpRequestLogs_UploadUserApplicationLog_Response Clone()
```

#### Returns

 [CHelpRequestLogs\_UploadUserApplicationLog\_Response](Divine.Protobufs.Steam.CHelpRequestLogs\_UploadUserApplicationLog\_Response.md)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_Equals_Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_"></a> Equals\(CHelpRequestLogs\_UploadUserApplicationLog\_Response\)

```csharp
public bool Equals(CHelpRequestLogs_UploadUserApplicationLog_Response other)
```

#### Parameters

`other` [CHelpRequestLogs\_UploadUserApplicationLog\_Response](Divine.Protobufs.Steam.CHelpRequestLogs\_UploadUserApplicationLog\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_MergeFrom_Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_"></a> MergeFrom\(CHelpRequestLogs\_UploadUserApplicationLog\_Response\)

```csharp
public void MergeFrom(CHelpRequestLogs_UploadUserApplicationLog_Response other)
```

#### Parameters

`other` [CHelpRequestLogs\_UploadUserApplicationLog\_Response](Divine.Protobufs.Steam.CHelpRequestLogs\_UploadUserApplicationLog\_Response.md)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CHelpRequestLogs_UploadUserApplicationLog_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

