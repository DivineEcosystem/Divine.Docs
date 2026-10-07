# <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest"></a> Class CMsgDOTAUnanchorPhoneNumberRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAUnanchorPhoneNumberRequest : IMessage<CMsgDOTAUnanchorPhoneNumberRequest>, IEquatable<CMsgDOTAUnanchorPhoneNumberRequest>, IDeepCloneable<CMsgDOTAUnanchorPhoneNumberRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAUnanchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAUnanchorPhoneNumberRequest.md)

#### Implements

IMessage<CMsgDOTAUnanchorPhoneNumberRequest\>, 
[IEquatable<CMsgDOTAUnanchorPhoneNumberRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAUnanchorPhoneNumberRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTAUnanchorPhoneNumberRequest\>\(CMsgDOTAUnanchorPhoneNumberRequest, params CMsgDOTAUnanchorPhoneNumberRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest__ctor"></a> CMsgDOTAUnanchorPhoneNumberRequest\(\)

```csharp
public CMsgDOTAUnanchorPhoneNumberRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_"></a> CMsgDOTAUnanchorPhoneNumberRequest\(CMsgDOTAUnanchorPhoneNumberRequest\)

```csharp
public CMsgDOTAUnanchorPhoneNumberRequest(CMsgDOTAUnanchorPhoneNumberRequest other)
```

#### Parameters

`other` [CMsgDOTAUnanchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAUnanchorPhoneNumberRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAUnanchorPhoneNumberRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAUnanchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAUnanchorPhoneNumberRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAUnanchorPhoneNumberRequest Clone()
```

#### Returns

 [CMsgDOTAUnanchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAUnanchorPhoneNumberRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_"></a> Equals\(CMsgDOTAUnanchorPhoneNumberRequest\)

```csharp
public bool Equals(CMsgDOTAUnanchorPhoneNumberRequest other)
```

#### Parameters

`other` [CMsgDOTAUnanchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAUnanchorPhoneNumberRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_"></a> MergeFrom\(CMsgDOTAUnanchorPhoneNumberRequest\)

```csharp
public void MergeFrom(CMsgDOTAUnanchorPhoneNumberRequest other)
```

#### Parameters

`other` [CMsgDOTAUnanchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAUnanchorPhoneNumberRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAUnanchorPhoneNumberRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

