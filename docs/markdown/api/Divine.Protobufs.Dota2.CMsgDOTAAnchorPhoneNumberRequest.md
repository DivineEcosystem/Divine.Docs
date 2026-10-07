# <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest"></a> Class CMsgDOTAAnchorPhoneNumberRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAAnchorPhoneNumberRequest : IMessage<CMsgDOTAAnchorPhoneNumberRequest>, IEquatable<CMsgDOTAAnchorPhoneNumberRequest>, IDeepCloneable<CMsgDOTAAnchorPhoneNumberRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAAnchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberRequest.md)

#### Implements

IMessage<CMsgDOTAAnchorPhoneNumberRequest\>, 
[IEquatable<CMsgDOTAAnchorPhoneNumberRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAAnchorPhoneNumberRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTAAnchorPhoneNumberRequest\>\(CMsgDOTAAnchorPhoneNumberRequest, params CMsgDOTAAnchorPhoneNumberRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest__ctor"></a> CMsgDOTAAnchorPhoneNumberRequest\(\)

```csharp
public CMsgDOTAAnchorPhoneNumberRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_"></a> CMsgDOTAAnchorPhoneNumberRequest\(CMsgDOTAAnchorPhoneNumberRequest\)

```csharp
public CMsgDOTAAnchorPhoneNumberRequest(CMsgDOTAAnchorPhoneNumberRequest other)
```

#### Parameters

`other` [CMsgDOTAAnchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberRequest.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAAnchorPhoneNumberRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAAnchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAAnchorPhoneNumberRequest Clone()
```

#### Returns

 [CMsgDOTAAnchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_"></a> Equals\(CMsgDOTAAnchorPhoneNumberRequest\)

```csharp
public bool Equals(CMsgDOTAAnchorPhoneNumberRequest other)
```

#### Parameters

`other` [CMsgDOTAAnchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_"></a> MergeFrom\(CMsgDOTAAnchorPhoneNumberRequest\)

```csharp
public void MergeFrom(CMsgDOTAAnchorPhoneNumberRequest other)
```

#### Parameters

`other` [CMsgDOTAAnchorPhoneNumberRequest](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

