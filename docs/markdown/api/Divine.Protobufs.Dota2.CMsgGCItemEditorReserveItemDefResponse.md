# <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse"></a> Class CMsgGCItemEditorReserveItemDefResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCItemEditorReserveItemDefResponse : IMessage<CMsgGCItemEditorReserveItemDefResponse>, IEquatable<CMsgGCItemEditorReserveItemDefResponse>, IDeepCloneable<CMsgGCItemEditorReserveItemDefResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCItemEditorReserveItemDefResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDefResponse.md)

#### Implements

IMessage<CMsgGCItemEditorReserveItemDefResponse\>, 
[IEquatable<CMsgGCItemEditorReserveItemDefResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCItemEditorReserveItemDefResponse\>, 
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
[EnumerableExtensions.In<CMsgGCItemEditorReserveItemDefResponse\>\(CMsgGCItemEditorReserveItemDefResponse, params CMsgGCItemEditorReserveItemDefResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse__ctor"></a> CMsgGCItemEditorReserveItemDefResponse\(\)

```csharp
public CMsgGCItemEditorReserveItemDefResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse__ctor_Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_"></a> CMsgGCItemEditorReserveItemDefResponse\(CMsgGCItemEditorReserveItemDefResponse\)

```csharp
public CMsgGCItemEditorReserveItemDefResponse(CMsgGCItemEditorReserveItemDefResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReserveItemDefResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDefResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_DefIndexFieldNumber"></a> DefIndexFieldNumber

```csharp
public const int DefIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_UsernameFieldNumber"></a> UsernameFieldNumber

```csharp
public const int UsernameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_DefIndex"></a> DefIndex

```csharp
public uint DefIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_HasDefIndex"></a> HasDefIndex

```csharp
public bool HasDefIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_HasUsername"></a> HasUsername

```csharp
public bool HasUsername { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCItemEditorReserveItemDefResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCItemEditorReserveItemDefResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDefResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_Username"></a> Username

```csharp
public string Username { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_ClearDefIndex"></a> ClearDefIndex\(\)

```csharp
public void ClearDefIndex()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_ClearUsername"></a> ClearUsername\(\)

```csharp
public void ClearUsername()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCItemEditorReserveItemDefResponse Clone()
```

#### Returns

 [CMsgGCItemEditorReserveItemDefResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDefResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_Equals_Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_"></a> Equals\(CMsgGCItemEditorReserveItemDefResponse\)

```csharp
public bool Equals(CMsgGCItemEditorReserveItemDefResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReserveItemDefResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDefResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_"></a> MergeFrom\(CMsgGCItemEditorReserveItemDefResponse\)

```csharp
public void MergeFrom(CMsgGCItemEditorReserveItemDefResponse other)
```

#### Parameters

`other` [CMsgGCItemEditorReserveItemDefResponse](Divine.Protobufs.Dota2.CMsgGCItemEditorReserveItemDefResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCItemEditorReserveItemDefResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

