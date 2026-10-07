# <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect"></a> Class CMsgDOTAPlayerFailedToConnect

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPlayerFailedToConnect : IMessage<CMsgDOTAPlayerFailedToConnect>, IEquatable<CMsgDOTAPlayerFailedToConnect>, IDeepCloneable<CMsgDOTAPlayerFailedToConnect>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPlayerFailedToConnect](Divine.Protobufs.Dota2.CMsgDOTAPlayerFailedToConnect.md)

#### Implements

IMessage<CMsgDOTAPlayerFailedToConnect\>, 
[IEquatable<CMsgDOTAPlayerFailedToConnect\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPlayerFailedToConnect\>, 
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
[EnumerableExtensions.In<CMsgDOTAPlayerFailedToConnect\>\(CMsgDOTAPlayerFailedToConnect, params CMsgDOTAPlayerFailedToConnect\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect__ctor"></a> CMsgDOTAPlayerFailedToConnect\(\)

```csharp
public CMsgDOTAPlayerFailedToConnect()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect__ctor_Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_"></a> CMsgDOTAPlayerFailedToConnect\(CMsgDOTAPlayerFailedToConnect\)

```csharp
public CMsgDOTAPlayerFailedToConnect(CMsgDOTAPlayerFailedToConnect other)
```

#### Parameters

`other` [CMsgDOTAPlayerFailedToConnect](Divine.Protobufs.Dota2.CMsgDOTAPlayerFailedToConnect.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_AbandonedLoadersFieldNumber"></a> AbandonedLoadersFieldNumber

```csharp
public const int AbandonedLoadersFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_FailedLoadersFieldNumber"></a> FailedLoadersFieldNumber

```csharp
public const int FailedLoadersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_AbandonedLoaders"></a> AbandonedLoaders

```csharp
public RepeatedField<ulong> AbandonedLoaders { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_FailedLoaders"></a> FailedLoaders

```csharp
public RepeatedField<ulong> FailedLoaders { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPlayerFailedToConnect> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPlayerFailedToConnect](Divine.Protobufs.Dota2.CMsgDOTAPlayerFailedToConnect.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPlayerFailedToConnect Clone()
```

#### Returns

 [CMsgDOTAPlayerFailedToConnect](Divine.Protobufs.Dota2.CMsgDOTAPlayerFailedToConnect.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_Equals_Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_"></a> Equals\(CMsgDOTAPlayerFailedToConnect\)

```csharp
public bool Equals(CMsgDOTAPlayerFailedToConnect other)
```

#### Parameters

`other` [CMsgDOTAPlayerFailedToConnect](Divine.Protobufs.Dota2.CMsgDOTAPlayerFailedToConnect.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_"></a> MergeFrom\(CMsgDOTAPlayerFailedToConnect\)

```csharp
public void MergeFrom(CMsgDOTAPlayerFailedToConnect other)
```

#### Parameters

`other` [CMsgDOTAPlayerFailedToConnect](Divine.Protobufs.Dota2.CMsgDOTAPlayerFailedToConnect.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPlayerFailedToConnect_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

