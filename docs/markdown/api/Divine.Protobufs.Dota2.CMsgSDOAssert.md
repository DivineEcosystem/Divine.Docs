# <a id="Divine_Protobufs_Dota2_CMsgSDOAssert"></a> Class CMsgSDOAssert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSDOAssert : IMessage<CMsgSDOAssert>, IEquatable<CMsgSDOAssert>, IDeepCloneable<CMsgSDOAssert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSDOAssert](Divine.Protobufs.Dota2.CMsgSDOAssert.md)

#### Implements

IMessage<CMsgSDOAssert\>, 
[IEquatable<CMsgSDOAssert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSDOAssert\>, 
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
[EnumerableExtensions.In<CMsgSDOAssert\>\(CMsgSDOAssert, params CMsgSDOAssert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert__ctor"></a> CMsgSDOAssert\(\)

```csharp
public CMsgSDOAssert()
```

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert__ctor_Divine_Protobufs_Dota2_CMsgSDOAssert_"></a> CMsgSDOAssert\(CMsgSDOAssert\)

```csharp
public CMsgSDOAssert(CMsgSDOAssert other)
```

#### Parameters

`other` [CMsgSDOAssert](Divine.Protobufs.Dota2.CMsgSDOAssert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_RequestsFieldNumber"></a> RequestsFieldNumber

```csharp
public const int RequestsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_SdoTypeFieldNumber"></a> SdoTypeFieldNumber

```csharp
public const int SdoTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_HasSdoType"></a> HasSdoType

```csharp
public bool HasSdoType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSDOAssert> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSDOAssert](Divine.Protobufs.Dota2.CMsgSDOAssert.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_Requests"></a> Requests

```csharp
public RepeatedField<CMsgSDOAssert.Types.Request> Requests { get; }
```

#### Property Value

 RepeatedField<[CMsgSDOAssert](Divine.Protobufs.Dota2.CMsgSDOAssert.md).[Types](Divine.Protobufs.Dota2.CMsgSDOAssert.Types.md).[Request](Divine.Protobufs.Dota2.CMsgSDOAssert.Types.Request.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_SdoType"></a> SdoType

```csharp
public int SdoType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_ClearSdoType"></a> ClearSdoType\(\)

```csharp
public void ClearSdoType()
```

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_Clone"></a> Clone\(\)

```csharp
public CMsgSDOAssert Clone()
```

#### Returns

 [CMsgSDOAssert](Divine.Protobufs.Dota2.CMsgSDOAssert.md)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_Equals_Divine_Protobufs_Dota2_CMsgSDOAssert_"></a> Equals\(CMsgSDOAssert\)

```csharp
public bool Equals(CMsgSDOAssert other)
```

#### Parameters

`other` [CMsgSDOAssert](Divine.Protobufs.Dota2.CMsgSDOAssert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_MergeFrom_Divine_Protobufs_Dota2_CMsgSDOAssert_"></a> MergeFrom\(CMsgSDOAssert\)

```csharp
public void MergeFrom(CMsgSDOAssert other)
```

#### Parameters

`other` [CMsgSDOAssert](Divine.Protobufs.Dota2.CMsgSDOAssert.md)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgSDOAssert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

