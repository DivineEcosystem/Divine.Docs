# <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response"></a> Class CGCToGCMsgMasterAck\_Response

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCToGCMsgMasterAck_Response : IMessage<CGCToGCMsgMasterAck_Response>, IEquatable<CGCToGCMsgMasterAck_Response>, IDeepCloneable<CGCToGCMsgMasterAck_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCToGCMsgMasterAck\_Response](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck\_Response.md)

#### Implements

IMessage<CGCToGCMsgMasterAck\_Response\>, 
[IEquatable<CGCToGCMsgMasterAck\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCToGCMsgMasterAck\_Response\>, 
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
[EnumerableExtensions.In<CGCToGCMsgMasterAck\_Response\>\(CGCToGCMsgMasterAck\_Response, params CGCToGCMsgMasterAck\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response__ctor"></a> CGCToGCMsgMasterAck\_Response\(\)

```csharp
public CGCToGCMsgMasterAck_Response()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response__ctor_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_"></a> CGCToGCMsgMasterAck\_Response\(CGCToGCMsgMasterAck\_Response\)

```csharp
public CGCToGCMsgMasterAck_Response(CGCToGCMsgMasterAck_Response other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck\_Response](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck\_Response.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_Eresult"></a> Eresult

```csharp
public int Eresult { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_Parser"></a> Parser

```csharp
public static MessageParser<CGCToGCMsgMasterAck_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CGCToGCMsgMasterAck\_Response](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_Clone"></a> Clone\(\)

```csharp
public CGCToGCMsgMasterAck_Response Clone()
```

#### Returns

 [CGCToGCMsgMasterAck\_Response](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck\_Response.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_Equals_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_"></a> Equals\(CGCToGCMsgMasterAck\_Response\)

```csharp
public bool Equals(CGCToGCMsgMasterAck_Response other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck\_Response](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_MergeFrom_Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_"></a> MergeFrom\(CGCToGCMsgMasterAck\_Response\)

```csharp
public void MergeFrom(CGCToGCMsgMasterAck_Response other)
```

#### Parameters

`other` [CGCToGCMsgMasterAck\_Response](Divine.Protobufs.Dota2.CGCToGCMsgMasterAck\_Response.md)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CGCToGCMsgMasterAck_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

