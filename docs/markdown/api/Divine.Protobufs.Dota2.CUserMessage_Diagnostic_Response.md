# <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response"></a> Class CUserMessage\_Diagnostic\_Response

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_Diagnostic_Response : IMessage<CUserMessage_Diagnostic_Response>, IEquatable<CUserMessage_Diagnostic_Response>, IDeepCloneable<CUserMessage_Diagnostic_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_Diagnostic\_Response](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.md)

#### Implements

IMessage<CUserMessage\_Diagnostic\_Response\>, 
[IEquatable<CUserMessage\_Diagnostic\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_Diagnostic\_Response\>, 
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
[EnumerableExtensions.In<CUserMessage\_Diagnostic\_Response\>\(CUserMessage\_Diagnostic\_Response, params CUserMessage\_Diagnostic\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response__ctor"></a> CUserMessage\_Diagnostic\_Response\(\)

```csharp
public CUserMessage_Diagnostic_Response()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response__ctor_Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_"></a> CUserMessage\_Diagnostic\_Response\(CUserMessage\_Diagnostic\_Response\)

```csharp
public CUserMessage_Diagnostic_Response(CUserMessage_Diagnostic_Response other)
```

#### Parameters

`other` [CUserMessage\_Diagnostic\_Response](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_BuildVersionFieldNumber"></a> BuildVersionFieldNumber

```csharp
public const int BuildVersionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_DiagnosticsFieldNumber"></a> DiagnosticsFieldNumber

```csharp
public const int DiagnosticsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_InstanceFieldNumber"></a> InstanceFieldNumber

```csharp
public const int InstanceFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_OsversionFieldNumber"></a> OsversionFieldNumber

```csharp
public const int OsversionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_PlatformFieldNumber"></a> PlatformFieldNumber

```csharp
public const int PlatformFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_StartTimeFieldNumber"></a> StartTimeFieldNumber

```csharp
public const int StartTimeFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_BuildVersion"></a> BuildVersion

```csharp
public int BuildVersion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Diagnostics"></a> Diagnostics

```csharp
public RepeatedField<CUserMessage_Diagnostic_Response.Types.Diagnostic> Diagnostics { get; }
```

#### Property Value

 RepeatedField<[CUserMessage\_Diagnostic\_Response](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.Types.md).[Diagnostic](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.Types.Diagnostic.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_HasBuildVersion"></a> HasBuildVersion

```csharp
public bool HasBuildVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_HasInstance"></a> HasInstance

```csharp
public bool HasInstance { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_HasOsversion"></a> HasOsversion

```csharp
public bool HasOsversion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_HasPlatform"></a> HasPlatform

```csharp
public bool HasPlatform { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_HasStartTime"></a> HasStartTime

```csharp
public bool HasStartTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Instance"></a> Instance

```csharp
public int Instance { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Osversion"></a> Osversion

```csharp
public int Osversion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_Diagnostic_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_Diagnostic\_Response](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Platform"></a> Platform

```csharp
public int Platform { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_StartTime"></a> StartTime

```csharp
public long StartTime { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_ClearBuildVersion"></a> ClearBuildVersion\(\)

```csharp
public void ClearBuildVersion()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_ClearInstance"></a> ClearInstance\(\)

```csharp
public void ClearInstance()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_ClearOsversion"></a> ClearOsversion\(\)

```csharp
public void ClearOsversion()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_ClearPlatform"></a> ClearPlatform\(\)

```csharp
public void ClearPlatform()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_ClearStartTime"></a> ClearStartTime\(\)

```csharp
public void ClearStartTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Clone"></a> Clone\(\)

```csharp
public CUserMessage_Diagnostic_Response Clone()
```

#### Returns

 [CUserMessage\_Diagnostic\_Response](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_Equals_Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_"></a> Equals\(CUserMessage\_Diagnostic\_Response\)

```csharp
public bool Equals(CUserMessage_Diagnostic_Response other)
```

#### Parameters

`other` [CUserMessage\_Diagnostic\_Response](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_"></a> MergeFrom\(CUserMessage\_Diagnostic\_Response\)

```csharp
public void MergeFrom(CUserMessage_Diagnostic_Response other)
```

#### Parameters

`other` [CUserMessage\_Diagnostic\_Response](Divine.Protobufs.Dota2.CUserMessage\_Diagnostic\_Response.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_Diagnostic_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

