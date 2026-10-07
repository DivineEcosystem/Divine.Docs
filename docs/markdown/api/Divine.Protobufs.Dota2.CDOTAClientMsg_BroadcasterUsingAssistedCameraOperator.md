# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator"></a> Class CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator : IMessage<CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator>, IEquatable<CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator>, IDeepCloneable<CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator.md)

#### Implements

IMessage<CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\>, 
[IEquatable<CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\>\(CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator, params CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator__ctor"></a> CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\(\)

```csharp
public CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_"></a> CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\(CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\)

```csharp
public CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator(CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator other)
```

#### Parameters

`other` [CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_EnabledFieldNumber"></a> EnabledFieldNumber

```csharp
public const int EnabledFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_Enabled"></a> Enabled

```csharp
public bool Enabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_HasEnabled"></a> HasEnabled

```csharp
public bool HasEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_ClearEnabled"></a> ClearEnabled\(\)

```csharp
public void ClearEnabled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator Clone()
```

#### Returns

 [CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_"></a> Equals\(CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\)

```csharp
public bool Equals(CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator other)
```

#### Parameters

`other` [CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_"></a> MergeFrom\(CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator\)

```csharp
public void MergeFrom(CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator other)
```

#### Parameters

`other` [CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator](Divine.Protobufs.Dota2.CDOTAClientMsg\_BroadcasterUsingAssistedCameraOperator.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BroadcasterUsingAssistedCameraOperator_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

