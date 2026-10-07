# <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response"></a> Class CMsgGCMsgMasterSetDirectory\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgMasterSetDirectory_Response : IMessage<CMsgGCMsgMasterSetDirectory_Response>, IEquatable<CMsgGCMsgMasterSetDirectory_Response>, IDeepCloneable<CMsgGCMsgMasterSetDirectory_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgMasterSetDirectory\_Response](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory\_Response.md)

#### Implements

IMessage<CMsgGCMsgMasterSetDirectory\_Response\>, 
[IEquatable<CMsgGCMsgMasterSetDirectory\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgMasterSetDirectory\_Response\>, 
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
[EnumerableExtensions.In<CMsgGCMsgMasterSetDirectory\_Response\>\(CMsgGCMsgMasterSetDirectory\_Response, params CMsgGCMsgMasterSetDirectory\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response__ctor"></a> CMsgGCMsgMasterSetDirectory\_Response\(\)

```csharp
public CMsgGCMsgMasterSetDirectory_Response()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response__ctor_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_"></a> CMsgGCMsgMasterSetDirectory\_Response\(CMsgGCMsgMasterSetDirectory\_Response\)

```csharp
public CMsgGCMsgMasterSetDirectory_Response(CMsgGCMsgMasterSetDirectory_Response other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory\_Response](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_Eresult"></a> Eresult

```csharp
public int Eresult { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgMasterSetDirectory_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgMasterSetDirectory\_Response](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgMasterSetDirectory_Response Clone()
```

#### Returns

 [CMsgGCMsgMasterSetDirectory\_Response](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_Equals_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_"></a> Equals\(CMsgGCMsgMasterSetDirectory\_Response\)

```csharp
public bool Equals(CMsgGCMsgMasterSetDirectory_Response other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory\_Response](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_"></a> MergeFrom\(CMsgGCMsgMasterSetDirectory\_Response\)

```csharp
public void MergeFrom(CMsgGCMsgMasterSetDirectory_Response other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetDirectory\_Response](Divine.Protobufs.Steam.CMsgGCMsgMasterSetDirectory\_Response.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetDirectory_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

