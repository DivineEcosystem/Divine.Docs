# <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus"></a> Class CMsgDOTASetGroupOpenStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASetGroupOpenStatus : IMessage<CMsgDOTASetGroupOpenStatus>, IEquatable<CMsgDOTASetGroupOpenStatus>, IDeepCloneable<CMsgDOTASetGroupOpenStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASetGroupOpenStatus](Divine.Protobufs.Dota2.CMsgDOTASetGroupOpenStatus.md)

#### Implements

IMessage<CMsgDOTASetGroupOpenStatus\>, 
[IEquatable<CMsgDOTASetGroupOpenStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASetGroupOpenStatus\>, 
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
[EnumerableExtensions.In<CMsgDOTASetGroupOpenStatus\>\(CMsgDOTASetGroupOpenStatus, params CMsgDOTASetGroupOpenStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus__ctor"></a> CMsgDOTASetGroupOpenStatus\(\)

```csharp
public CMsgDOTASetGroupOpenStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus__ctor_Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_"></a> CMsgDOTASetGroupOpenStatus\(CMsgDOTASetGroupOpenStatus\)

```csharp
public CMsgDOTASetGroupOpenStatus(CMsgDOTASetGroupOpenStatus other)
```

#### Parameters

`other` [CMsgDOTASetGroupOpenStatus](Divine.Protobufs.Dota2.CMsgDOTASetGroupOpenStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_OpenFieldNumber"></a> OpenFieldNumber

```csharp
public const int OpenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_HasOpen"></a> HasOpen

```csharp
public bool HasOpen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_Open"></a> Open

```csharp
public bool Open { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASetGroupOpenStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASetGroupOpenStatus](Divine.Protobufs.Dota2.CMsgDOTASetGroupOpenStatus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_ClearOpen"></a> ClearOpen\(\)

```csharp
public void ClearOpen()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASetGroupOpenStatus Clone()
```

#### Returns

 [CMsgDOTASetGroupOpenStatus](Divine.Protobufs.Dota2.CMsgDOTASetGroupOpenStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_Equals_Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_"></a> Equals\(CMsgDOTASetGroupOpenStatus\)

```csharp
public bool Equals(CMsgDOTASetGroupOpenStatus other)
```

#### Parameters

`other` [CMsgDOTASetGroupOpenStatus](Divine.Protobufs.Dota2.CMsgDOTASetGroupOpenStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_"></a> MergeFrom\(CMsgDOTASetGroupOpenStatus\)

```csharp
public void MergeFrom(CMsgDOTASetGroupOpenStatus other)
```

#### Parameters

`other` [CMsgDOTASetGroupOpenStatus](Divine.Protobufs.Dota2.CMsgDOTASetGroupOpenStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASetGroupOpenStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

