# <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit"></a> Class CMsgGCRankedPlayerInfoSubmit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCRankedPlayerInfoSubmit : IMessage<CMsgGCRankedPlayerInfoSubmit>, IEquatable<CMsgGCRankedPlayerInfoSubmit>, IDeepCloneable<CMsgGCRankedPlayerInfoSubmit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCRankedPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmit.md)

#### Implements

IMessage<CMsgGCRankedPlayerInfoSubmit\>, 
[IEquatable<CMsgGCRankedPlayerInfoSubmit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCRankedPlayerInfoSubmit\>, 
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
[EnumerableExtensions.In<CMsgGCRankedPlayerInfoSubmit\>\(CMsgGCRankedPlayerInfoSubmit, params CMsgGCRankedPlayerInfoSubmit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit__ctor"></a> CMsgGCRankedPlayerInfoSubmit\(\)

```csharp
public CMsgGCRankedPlayerInfoSubmit()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit__ctor_Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_"></a> CMsgGCRankedPlayerInfoSubmit\(CMsgGCRankedPlayerInfoSubmit\)

```csharp
public CMsgGCRankedPlayerInfoSubmit(CMsgGCRankedPlayerInfoSubmit other)
```

#### Parameters

`other` [CMsgGCRankedPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCRankedPlayerInfoSubmit> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCRankedPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmit.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_Clone"></a> Clone\(\)

```csharp
public CMsgGCRankedPlayerInfoSubmit Clone()
```

#### Returns

 [CMsgGCRankedPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmit.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_Equals_Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_"></a> Equals\(CMsgGCRankedPlayerInfoSubmit\)

```csharp
public bool Equals(CMsgGCRankedPlayerInfoSubmit other)
```

#### Parameters

`other` [CMsgGCRankedPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_MergeFrom_Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_"></a> MergeFrom\(CMsgGCRankedPlayerInfoSubmit\)

```csharp
public void MergeFrom(CMsgGCRankedPlayerInfoSubmit other)
```

#### Parameters

`other` [CMsgGCRankedPlayerInfoSubmit](Divine.Protobufs.Dota2.CMsgGCRankedPlayerInfoSubmit.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCRankedPlayerInfoSubmit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

