# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman"></a> Class CDOTAClientMsg\_BroadcasterUsingCameraman

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_BroadcasterUsingCameraman : IMessage<CDOTAClientMsg_BroadcasterUsingCameraman>, IEquatable<CDOTAClientMsg_BroadcasterUsingCameraman>, IDeepCloneable<CDOTAClientMsg_BroadcasterUsingCameraman>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_BroadcasterUsingCameraman](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingCameraman.md)

#### Implements

IMessage<CDOTAClientMsg\_BroadcasterUsingCameraman\>, 
[IEquatable<CDOTAClientMsg\_BroadcasterUsingCameraman\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_BroadcasterUsingCameraman\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_BroadcasterUsingCameraman\>\(CDOTAClientMsg\_BroadcasterUsingCameraman, params CDOTAClientMsg\_BroadcasterUsingCameraman\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman__ctor"></a> CDOTAClientMsg\_BroadcasterUsingCameraman\(\)

```csharp
public CDOTAClientMsg_BroadcasterUsingCameraman()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_"></a> CDOTAClientMsg\_BroadcasterUsingCameraman\(CDOTAClientMsg\_BroadcasterUsingCameraman\)

```csharp
public CDOTAClientMsg_BroadcasterUsingCameraman(CDOTAClientMsg_BroadcasterUsingCameraman other)
```

#### Parameters

`other` [CDOTAClientMsg\_BroadcasterUsingCameraman](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingCameraman.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_CameramanFieldNumber"></a> CameramanFieldNumber

```csharp
public const int CameramanFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_Cameraman"></a> Cameraman

```csharp
public bool Cameraman { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_HasCameraman"></a> HasCameraman

```csharp
public bool HasCameraman { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_BroadcasterUsingCameraman> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_BroadcasterUsingCameraman](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingCameraman.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_ClearCameraman"></a> ClearCameraman\(\)

```csharp
public void ClearCameraman()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_BroadcasterUsingCameraman Clone()
```

#### Returns

 [CDOTAClientMsg\_BroadcasterUsingCameraman](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingCameraman.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_"></a> Equals\(CDOTAClientMsg\_BroadcasterUsingCameraman\)

```csharp
public bool Equals(CDOTAClientMsg_BroadcasterUsingCameraman other)
```

#### Parameters

`other` [CDOTAClientMsg\_BroadcasterUsingCameraman](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingCameraman.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_"></a> MergeFrom\(CDOTAClientMsg\_BroadcasterUsingCameraman\)

```csharp
public void MergeFrom(CDOTAClientMsg_BroadcasterUsingCameraman other)
```

#### Parameters

`other` [CDOTAClientMsg\_BroadcasterUsingCameraman](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingCameraman.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingCameraman_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

