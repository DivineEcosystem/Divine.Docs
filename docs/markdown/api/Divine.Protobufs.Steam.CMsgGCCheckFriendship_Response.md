# <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response"></a> Class CMsgGCCheckFriendship\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCCheckFriendship_Response : IMessage<CMsgGCCheckFriendship_Response>, IEquatable<CMsgGCCheckFriendship_Response>, IDeepCloneable<CMsgGCCheckFriendship_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCCheckFriendship\_Response](Divine.Protobufs.Steam.CMsgGCCheckFriendship\_Response.md)

#### Implements

IMessage<CMsgGCCheckFriendship\_Response\>, 
[IEquatable<CMsgGCCheckFriendship\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCCheckFriendship\_Response\>, 
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
[EnumerableExtensions.In<CMsgGCCheckFriendship\_Response\>\(CMsgGCCheckFriendship\_Response, params CMsgGCCheckFriendship\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response__ctor"></a> CMsgGCCheckFriendship\_Response\(\)

```csharp
public CMsgGCCheckFriendship_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response__ctor_Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_"></a> CMsgGCCheckFriendship\_Response\(CMsgGCCheckFriendship\_Response\)

```csharp
public CMsgGCCheckFriendship_Response(CMsgGCCheckFriendship_Response other)
```

#### Parameters

`other` [CMsgGCCheckFriendship\_Response](Divine.Protobufs.Steam.CMsgGCCheckFriendship\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_FoundFriendshipFieldNumber"></a> FoundFriendshipFieldNumber

```csharp
public const int FoundFriendshipFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_FoundFriendship"></a> FoundFriendship

```csharp
public bool FoundFriendship { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_HasFoundFriendship"></a> HasFoundFriendship

```csharp
public bool HasFoundFriendship { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCCheckFriendship_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCCheckFriendship\_Response](Divine.Protobufs.Steam.CMsgGCCheckFriendship\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_ClearFoundFriendship"></a> ClearFoundFriendship\(\)

```csharp
public void ClearFoundFriendship()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_Clone"></a> Clone\(\)

```csharp
public CMsgGCCheckFriendship_Response Clone()
```

#### Returns

 [CMsgGCCheckFriendship\_Response](Divine.Protobufs.Steam.CMsgGCCheckFriendship\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_Equals_Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_"></a> Equals\(CMsgGCCheckFriendship\_Response\)

```csharp
public bool Equals(CMsgGCCheckFriendship_Response other)
```

#### Parameters

`other` [CMsgGCCheckFriendship\_Response](Divine.Protobufs.Steam.CMsgGCCheckFriendship\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_MergeFrom_Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_"></a> MergeFrom\(CMsgGCCheckFriendship\_Response\)

```csharp
public void MergeFrom(CMsgGCCheckFriendship_Response other)
```

#### Parameters

`other` [CMsgGCCheckFriendship\_Response](Divine.Protobufs.Steam.CMsgGCCheckFriendship\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCCheckFriendship_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

