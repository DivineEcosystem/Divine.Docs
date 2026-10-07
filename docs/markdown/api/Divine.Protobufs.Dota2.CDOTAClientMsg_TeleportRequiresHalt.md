# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt"></a> Class CDOTAClientMsg\_TeleportRequiresHalt

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_TeleportRequiresHalt : IMessage<CDOTAClientMsg_TeleportRequiresHalt>, IEquatable<CDOTAClientMsg_TeleportRequiresHalt>, IDeepCloneable<CDOTAClientMsg_TeleportRequiresHalt>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_TeleportRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_TeleportRequiresHalt.md)

#### Implements

IMessage<CDOTAClientMsg\_TeleportRequiresHalt\>, 
[IEquatable<CDOTAClientMsg\_TeleportRequiresHalt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_TeleportRequiresHalt\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_TeleportRequiresHalt\>\(CDOTAClientMsg\_TeleportRequiresHalt, params CDOTAClientMsg\_TeleportRequiresHalt\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt__ctor"></a> CDOTAClientMsg\_TeleportRequiresHalt\(\)

```csharp
public CDOTAClientMsg_TeleportRequiresHalt()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_"></a> CDOTAClientMsg\_TeleportRequiresHalt\(CDOTAClientMsg\_TeleportRequiresHalt\)

```csharp
public CDOTAClientMsg_TeleportRequiresHalt(CDOTAClientMsg_TeleportRequiresHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_TeleportRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_TeleportRequiresHalt.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_EnabledFieldNumber"></a> EnabledFieldNumber

```csharp
public const int EnabledFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_Enabled"></a> Enabled

```csharp
public bool Enabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_HasEnabled"></a> HasEnabled

```csharp
public bool HasEnabled { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_TeleportRequiresHalt> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_TeleportRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_TeleportRequiresHalt.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_ClearEnabled"></a> ClearEnabled\(\)

```csharp
public void ClearEnabled()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_TeleportRequiresHalt Clone()
```

#### Returns

 [CDOTAClientMsg\_TeleportRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_TeleportRequiresHalt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_"></a> Equals\(CDOTAClientMsg\_TeleportRequiresHalt\)

```csharp
public bool Equals(CDOTAClientMsg_TeleportRequiresHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_TeleportRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_TeleportRequiresHalt.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_"></a> MergeFrom\(CDOTAClientMsg\_TeleportRequiresHalt\)

```csharp
public void MergeFrom(CDOTAClientMsg_TeleportRequiresHalt other)
```

#### Parameters

`other` [CDOTAClientMsg\_TeleportRequiresHalt](Divine.Protobufs.Dota2.CDOTAClientMsg\_TeleportRequiresHalt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_TeleportRequiresHalt_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

