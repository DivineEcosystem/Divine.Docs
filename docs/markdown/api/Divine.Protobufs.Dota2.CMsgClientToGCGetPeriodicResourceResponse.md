# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse"></a> Class CMsgClientToGCGetPeriodicResourceResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetPeriodicResourceResponse : IMessage<CMsgClientToGCGetPeriodicResourceResponse>, IEquatable<CMsgClientToGCGetPeriodicResourceResponse>, IDeepCloneable<CMsgClientToGCGetPeriodicResourceResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.md)

#### Implements

IMessage<CMsgClientToGCGetPeriodicResourceResponse\>, 
[IEquatable<CMsgClientToGCGetPeriodicResourceResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetPeriodicResourceResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetPeriodicResourceResponse\>\(CMsgClientToGCGetPeriodicResourceResponse, params CMsgClientToGCGetPeriodicResourceResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse__ctor"></a> CMsgClientToGCGetPeriodicResourceResponse\(\)

```csharp
public CMsgClientToGCGetPeriodicResourceResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_"></a> CMsgClientToGCGetPeriodicResourceResponse\(CMsgClientToGCGetPeriodicResourceResponse\)

```csharp
public CMsgClientToGCGetPeriodicResourceResponse(CMsgClientToGCGetPeriodicResourceResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_PeriodicResourceValueFieldNumber"></a> PeriodicResourceValueFieldNumber

```csharp
public const int PeriodicResourceValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetPeriodicResourceResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_PeriodicResourceValue"></a> PeriodicResourceValue

```csharp
public CMsgPeriodicResourceValue PeriodicResourceValue { get; set; }
```

#### Property Value

 [CMsgPeriodicResourceValue](Divine.Protobufs.Dota2.CMsgPeriodicResourceValue.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_Result"></a> Result

```csharp
public CMsgClientToGCGetPeriodicResourceResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetPeriodicResourceResponse Clone()
```

#### Returns

 [CMsgClientToGCGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_"></a> Equals\(CMsgClientToGCGetPeriodicResourceResponse\)

```csharp
public bool Equals(CMsgClientToGCGetPeriodicResourceResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_"></a> MergeFrom\(CMsgClientToGCGetPeriodicResourceResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetPeriodicResourceResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetPeriodicResourceResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetPeriodicResourceResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetPeriodicResourceResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

